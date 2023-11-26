using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;


namespace WindowsFormsApp1
{
    public partial class Output_form : Form
    {

        string file_name;
        public FileStream output;
        public StreamWriter fileWriter;
        public StreamReader fileReader;
        private static ImageFormat format;

        public Output_form()
        {
            InitializeComponent();
        }

        private void bntExitLoginForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CaptureMyScreen()

        {

            try

            {

                //Creating a new Bitmap object

                Bitmap captureBitmap = new Bitmap(1024, 768, PixelFormat.Format32bppArgb);


                //Bitmap captureBitmap = new Bitmap(int width, int height, PixelFormat);

                //Creating a Rectangle object which will  

                //capture our Current Screen

                Rectangle captureRectangle = Screen.AllScreens[0].Bounds;



                //Creating a New Graphics Object

                Graphics captureGraphics = Graphics.FromImage(captureBitmap);



                //Copying Image from The Screen

                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);



                //Saving the Image File (I am here Saving it in My E drive).

                captureBitmap.Save(@"C:\Capture.jpg", ImageFormat.Jpeg);



                //Displaying the Successfull Result



                MessageBox.Show("Screen Captured");

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }

        }
        public static byte[] ConvertImageToByteArray(Image imageToConvert)
        {
            using (var ms = new MemoryStream())
            {
                Bitmap bmp = new Bitmap(imageToConvert);
                bmp.Save(ms, format);
                return ms.ToArray();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Your Request Details";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";


            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine("Your Name: " + textBox1.Text+"\n"+ "Losted Item: " + textBox2.Text + "\n" + "Fees: " + textBox3.Text + "\n" + "Recive Date: " + textBox4.Text + "\n" + "Where To Recive: " + textBox5.Text);
            }

           




            //using (ExcelEngine excelEngine = new ExcelEngine())
            //{
            //    IApplication application = excelEngine.Excel;
            //    application.DefaultVersion = ExcelVersion.Excel2016;

            //    //Create a workbook 
            //    IWorkbook workbook = application.Workbooks.Create(1);
            //    IWorksheet worksheet = workbook.Worksheets[0];
            //    worksheet.Range["A1:E5"].Text = "Sample";

            //    System.Drawing.Image imgProjStatus = worksheet.ConvertToImage(1, 1, 5, 5);
            //    imgProjStatus.Save(Server.MapPath("App_Data/Sample.png"), System.Drawing.Imaging.ImageFormat.Png);
            //    imgProjStatus.Dispose();
            //}














            //            Dim oBitmap As Bitmap;
            //oBitmap = New Bitmap("c:\\example.jpg")
            //Dim oGraphic As Graphics;
            //' Here create a new bitmap object of the same height and width of the image.
            //Dim bmpNew As Bitmap = New Bitmap(oBitmap.Width, oBitmap.Height)
            //oGraphic = Graphics.FromImage(bmpNew)
            //oGraphic.DrawImage(oBitmap, New Rectangle(0, 0, _
            //bmpNew.Width, bmpNew.Height), 0, 0, oBitmap.Width, _
            //oBitmap.Height, GraphicsUnit.Pixel)
            //' Release the lock on the image file. Of course,
            //' image from the image file is existing in Graphics object
            //oBitmap.Dispose()
            //oBitmap = bmpNew


            //Dim oBrush As New SolidBrush(Color.Black)
            //Dim ofont As New Font("Arial", 8)
            //oGraphic.DrawString("Some text to write", ofont, oBrush, 10, 10)
            //oGraphic.Dispose()
            //ofont.Dispose()
            //oBrush.Dispose()
            //oBitmap.Save("c:\\example.jpg", ImageFormat.Jpeg)
            //oBitmap.Dispose()





            //string outputFileName = "...";
            //using (MemoryStream memory = new MemoryStream())
            //{
            //    using (FileStream fs = new FileStream(outputFileName, FileMode.Create, FileAccess.ReadWrite))
            //    {
            //        object p = thumbBMP.Save(memory, ImageFormat.Jpeg);
            //        byte[] bytes = memory.ToArray();
            //        fs.Write(bytes, 0, bytes.Length);
            //    }
            //}


            //CaptureMyScreen();

            //using (var ms = new MemoryStream())
            //{
            //    Bitmap bmp = new Bitmap(imageToConvert);
            //    bmp.Save(ms, format);
            //    return ms.ToArray();
            //}


            //var image = ScreenCapture.CaptureActiveWindow();
            //object p = image.Save(@"C:\temp\snippetsource.jpg", BadImageFormatException.Jpeg);

            //ScreenCapture sc = new ScreenCapture();
            //// capture entire screen, and save it to a file
            //Image img = sc.CaptureScreen();
            //// display image in a Picture control named imageDisplay
            //this.imageDisplay.Image = img;
            //// capture this window, and save it
            //sc.CaptureWindowToFile(this.Handle, "C:\\temp2.gif", ImageFormat.Gif);

            //Rectangle bounds = this.Bounds;
            //using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            //{
            //    using (Graphics g = Graphics.FromImage(bitmap))
            //    {
            //        g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
            //    }
            //    bitmap.Save("C://test.jpg", ImageFormat.Jpeg);
            //}

            //file_name = @"text.txt";
            //output = new FileStream(file_name, FileMode.OpenOrCreate, FileAccess.Read);
            //// sets file to where data is written
            //fileReader = new StreamReader(output);
            ////MessageBox.Show("File Opend");

            //output.Seek(0, SeekOrigin.End);
            //string line;
            //string[] field;
            //int count = 0;

            //line = File.ReadLines(@"text.txt").Last(); ;


            //if (line != null && line != "")
            //{
            //    if (line[0] == '*')
            //        return;
            //    field = line.Split('|');


            //    textBox1.Text = field[0] + " " + field[1];
            //    textBox2.Text = field[6];
            //    textBox3.Text = field[7];
            //    textBox4.Text = "After 10 Days";
            //    textBox5.Text = field[5];

            //}



        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Output_form_Load(object sender, EventArgs e)
        {

            file_name = @"text.txt";
            output = new FileStream(file_name, FileMode.OpenOrCreate, FileAccess.Read);
            // sets file to where data is written
            fileReader = new StreamReader(output);
            //MessageBox.Show("File Opend");

            output.Seek(0, SeekOrigin.End);
            string line;
            string[] field;
            int count = 0;

            line = File.ReadLines(@"text.txt").Last(); ;


            if (line != null && line != "")
            {
                if (line[0] == '*')
                    return;
                field = line.Split('|');


                textBox1.Text = field[0] + " " + field[1];
                textBox2.Text = field[6];
                textBox3.Text = field[7];
                textBox4.Text = "After 10 Days";
                textBox5.Text = field[5];

            }


            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
