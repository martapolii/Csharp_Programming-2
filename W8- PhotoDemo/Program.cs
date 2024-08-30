namespace W8__PhotoDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create objects
            Photo standardPhoto = new Photo();
            Photo customPhoto = new Photo();

            MattedPhoto mattedPhoto = new MattedPhoto();
            FramedPhoto framedPhoto = new FramedPhoto();

            //set height and width (properties) for these objects:
            standardPhoto.Width = 8;
            standardPhoto.Height = 10;

            customPhoto.Width = 8;
            customPhoto.Height = 9;

            mattedPhoto.Width = 10;
            mattedPhoto.Height = 12;
            mattedPhoto.Colour = "white";

            framedPhoto.Width = 8;
            framedPhoto.Height = 10;
            framedPhoto.Material = "silver";
            framedPhoto.Style = "modern";

            Console.WriteLine(standardPhoto);
            Console.WriteLine(customPhoto.ToString());
            Console.WriteLine(mattedPhoto);
            Console.WriteLine(framedPhoto);
           
        }
    }
}
