using System;

namespace PhotoAlbum
{
    class PhotoAlbum
    {
        protected int numberOfPages;
        public PhotoAlbum()
        {
            numberOfPages = 16;
        }
        public PhotoAlbum(int numberOfPages)
        {
            this.numberOfPages = numberOfPages;
        }
        public int GetNumberOfPages()
        {
            return numberOfPages;
        }
    }
    class BigPhotoAlbum : PhotoAlbum
    {
        public BigPhotoAlbum()
        {
            numberOfPages = 64;
        }
    }
    class AlbumTest
    {
        static void Main()
        {
            bool debug = false;
            PhotoAlbum MyAlbum1 = new PhotoAlbum();
            Console.WriteLine(MyAlbum1.GetNumberOfPages());
            PhotoAlbum MyAlbum2 = new PhotoAlbum(24);
            Console.WriteLine(MyAlbum2.GetNumberOfPages());
            BigPhotoAlbum MyBigPhotoAlbum1 = new BigPhotoAlbum();
            Console.WriteLine(MyBigPhotoAlbum1.GetNumberOfPages());
            if (debug)
                Console.ReadLine();
        }
    }
}

