using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawBot
{
    public struct colorInfo
    {
        public int x, y, r, g, b;
    }

    public partial class Bot : Form
    {

        // default region
        int leftTopX = 425;
        int leftTopY = 293;
        int rightBottomX = 933;
        int rightBottomY = 788;


        // default values
        string tempColours = "";
        int cIndex = 0;
        bool existPalette = false;

        public colorInfo[] colourPalette { get; set; }
        int paletteAmount;
        bool paletteLoaded = false;


        string imagePath = "";
        Bitmap image;

        public Bot()
        {
            InitializeComponent();
        }

        private void Bot_Load(object sender, EventArgs e)
        {
            TopMost = true;
            lbl_ImageDir.Text = "";
            lbl_LoadedConfig.Text = "";


            Directory.CreateDirectory("configs");
            refreshColoursList();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            // guard clauses
            if (lbl_ImageDir.Text == "")
            {
                MessageBox.Show("You need to select an image");
                return;
            }

            if (leftTopX * rightBottomX == 0 || leftTopY * rightBottomY == 0)
            {
                MessageBox.Show("You need to calibrate first");
                return;
            }

            if (!paletteLoaded)
            {
                MessageBox.Show("You need to select an existing configuration or create one");
                return;
            }


            TopMost = true;

            int qualityStep = 200 / 100;
            double speed = 0.0007;

            int xBound = (rightBottomX - leftTopX) / qualityStep;
            int yBound = (rightBottomY - leftTopY) / qualityStep;

            if (txt_imageURL.Text == "")
            {
                // image from local
                try
                {
                    image = new Bitmap(Image.FromFile(imagePath), new Size(xBound, yBound));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading local image\n\n" + ex);
                    return;
                }
            }
            else
            {
                // image from website
                try
                {
                    var request = WebRequest.Create(txt_imageURL.Text);

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                        image = new Bitmap(Bitmap.FromStream(stream), new Size(xBound, yBound));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading web image\n\n" + ex);
                    return;
                }
            }

            // change pen size
            Cursor.Position = new Point(653, 858);
            Win32.clickCursor(0.0001);
            Cursor.Position = new Point(654, 609);
            Win32.clickCursor(0.0001);

            int completeState = 0;

            completeState = startDrawing(xBound, yBound, qualityStep, speed);

            image.Dispose();
            TopMost = false;

            if (completeState == 1) return;
            Win32.moveCursor(leftTopX, leftTopY);
        }


        private int startDrawing(int xBound, int yBound, int qualityStep, double speed)
        {
            int area = xBound * yBound;

            int x_pixel = 0;
            int y_pixel = 0;

            int[,] quantizedImage = new int[xBound, yBound];
            for (int i = 0; i < area; i++)
            {
                if (x_pixel == xBound)
                {
                    x_pixel = 0;
                    y_pixel++;
                }

                Color color = image.GetPixel(x_pixel, y_pixel);

                int nearestDist = Int32.MaxValue;
                for (int j = 0; j < paletteAmount; j++)
                {
                    int dist = Maths.getDist(color.R, colourPalette[j].r, color.G, colourPalette[j].g, color.B, colourPalette[j].b);

                    if (dist < nearestDist)
                        nearestDist = dist;
                }
                quantizedImage[x_pixel, y_pixel] = nearestDist;

                x_pixel++;
            }

            Win32.moveCursor(leftTopX, leftTopY);

            int colorIndex = 0;
            int[,] pixelIndex = new int[xBound, yBound];


            for (int j = 0; j < paletteAmount - 1; j++)
            {
                Win32.moveCursor(colourPalette[colorIndex].x, colourPalette[colorIndex].y);
                Win32.clickCursor(speed);

                int x_index = 0;
                int y_index = 0;

                int mouseX_pos = leftTopX;
                int mouseY_pos = leftTopY;

                for (int i = 0; i < area; i++)
                {
                    // stop drawing
                    if (Win32.keyDetect("Escape") == true)
                    {
                        int x_pause_temp = Cursor.Position.X;
                        int y_pause_temp = Cursor.Position.Y;

                        DialogResult prompt = MessageBox.Show("Paused.\n\nPress OK to continue\nPress CANCEL to stop", "", MessageBoxButtons.OKCancel);
                        if (prompt == DialogResult.Cancel) return 1;

                        Win32.moveCursor(x_pause_temp, y_pause_temp);
                    }

                    if (x_index == xBound)
                    {
                        mouseX_pos = mouseX_pos - xBound * qualityStep;
                        mouseY_pos = mouseY_pos + qualityStep;

                        x_index = 0;
                        y_index++;
                    }

                    Color color = image.GetPixel(x_index, y_index);
                    int dist = Maths.getDist(color.R, colourPalette[colorIndex].r, color.G, colourPalette[colorIndex].g, color.B, colourPalette[colorIndex].b);

                    if (dist == quantizedImage[x_index, y_index] && pixelIndex[x_index, y_index] == 0)
                    {
                        Win32.moveCursor(mouseX_pos, mouseY_pos);
                        Win32.clickCursor(speed);

                        pixelIndex[x_index, y_index] = 1;
                    }

                    mouseX_pos += qualityStep;
                    x_index++;
                }

                // loop over every colour
                colorIndex++;
            }

            return 0;
        }


        private void btn_loadImage_Click(object sender, EventArgs e)
        {
            openImageDialog.Filter = "PNG|*.png|JPG|*.jpg";
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openImageDialog.FileName;
                lbl_ImageDir.Text = $"{Path.GetFileName(imagePath)}";
            }
        }

        private void txt_imageURL_TextChanged(object sender, EventArgs e)
        {
            lbl_ImageDir.Text = $"{txt_imageURL.Text}";
            if (txt_imageURL.Text == "") lbl_ImageDir.Text = Path.GetFileName(imagePath);
        }

        private void lbl_ImageDir_TextChanged(object sender, EventArgs e)
        {
            if (lbl_ImageDir.Text.Length > 9)
                lbl_ImageDir.Text = lbl_ImageDir.Text.Substring(lbl_ImageDir.Text.Length - 9);
        }

        private void btn_TopLeft_Click(object sender, EventArgs e)
        {
            TopMost = true;
            while (Win32.keyDetect("LeftMouse") == false) { }

            leftTopX = Cursor.Position.X;
            leftTopY = Cursor.Position.Y;
            lbl_TopLeftPos.Text = (leftTopX, leftTopY).ToString();
        }

        private void btn_BottomLeft_Click(object sender, EventArgs e)
        {
            TopMost = true;
            while (Win32.keyDetect("LeftMouse") == false) { }

            rightBottomX = Cursor.Position.X;
            rightBottomY = Cursor.Position.Y;
            lbl_BottomRightPos.Text = (rightBottomX, rightBottomY).ToString();
        }

        private void btn_addColour_Click(object sender, EventArgs e)
        {
            if (existPalette == true)
            {
                tempColours = "";
                cIndex = 0;
                lbl_ColourIndex.Text = "Color 0"; lbl_ColourIndex.Refresh();
                panel_Colour.BackColor = Color.FromArgb(255, 0, 0, 0);

                existPalette = false;
            }

            TopMost = true;
            while (Win32.keyDetect("LeftMouse") == false) { }

            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            var rgb = Screen.GetColorAt(x, y);
            tempColours += "|" + x + "," + y + "," + rgb.Item1 + "," + rgb.Item2 + "," + rgb.Item3;
            cIndex++;

            lbl_ColourIndex.Text = "Color " + cIndex.ToString();
            panel_Colour.BackColor = Color.FromArgb(255, rgb.Item1, rgb.Item2, rgb.Item3);
        }

        private void btn_RemoveColour_Click(object sender, EventArgs e)
        {
            if (tempColours == "")
            {
                return;
            }

            cIndex--;
            if (cIndex == 0)
                tempColours = "";
            else
                tempColours = tempColours.Remove(tempColours.LastIndexOf('|'));

            lbl_ColourIndex.Text = "Color " + cIndex;
            panel_Colour.BackColor = Color.FromArgb(255, 0, 0, 0);
        }

        private void btn_SaveConfig_Click(object sender, EventArgs e)
        {
            if (tempColours == "") return;
            tempColours = tempColours.Substring(1);
            string name = txt_configName.Text == "" ? "config" + DateTime.Now.ToString("Mdy-hms") : txt_configName.Text;
            File.WriteAllText("configs\\" + name + ".palette", tempColours);
            refreshColoursList();

            txt_configName.Text = "";
            existPalette = true;
        }

        private void btn_LoadConfig_Click(object sender, EventArgs e)
        {
            if (Directory.GetFiles("configs", "*.*", SearchOption.TopDirectoryOnly).Length == 0)
            {
                return;
            }

            string paletteFilePath = "configs\\" + LBox_configs.SelectedItem + ".palette";
            string paletteFile = File.ReadAllText(paletteFilePath);

            string[] RGBpixel = paletteFile.Split('|');
            paletteAmount = RGBpixel.Length;
            colourPalette = new colorInfo[paletteFile.Length];

            for (int i = 0; i < RGBpixel.Length; i++)
            {
                string[] value = RGBpixel[i].Split(',');

                int[] valueInt = new int[5];
                for (int j = 0; j < 5; j++)
                    valueInt[j] = Int32.Parse(value[j]);

                colourPalette[i].x = valueInt[0];
                colourPalette[i].y = valueInt[1];
                colourPalette[i].r = valueInt[2];
                colourPalette[i].g = valueInt[3];
                colourPalette[i].b = valueInt[4];
            }

            lbl_LoadedConfig.Text = $"{Path.GetFileNameWithoutExtension(paletteFilePath)}";
            paletteLoaded = true;
        }

        private void btn_DeleteConfig_Click(object sender, EventArgs e)
        {
            if (Directory.GetFiles("configs", "*.*", SearchOption.TopDirectoryOnly).Length == 0)
            {
                return;
            }
            File.Delete("configs\\" + LBox_configs.SelectedItem + ".palette");
            refreshColoursList();
            if (LBox_configs.Items.Count > 0) LBox_configs.SelectedIndex = 0;

            lbl_LoadedConfig.Text = "";
            paletteLoaded = false;
        }


        private void refreshColoursList()
        {
            LBox_configs.Items.Clear();
            string[] paletteFiles = Directory.GetFiles("configs", "*.palette");
            for (int i = 0; i < paletteFiles.Length; i++)
                LBox_configs.Items.Add(Path.GetFileNameWithoutExtension(paletteFiles[i]));
        }

        private void panel_Colour_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_ColourIndex_Click(object sender, EventArgs e)
        {

        }

    }
}
