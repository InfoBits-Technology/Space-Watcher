namespace Space_Watcher.Class.Tool
{
    public static class BlendImage
    {
        private static void Blend(Bitmap backgroud, Bitmap front, int positionX, int positionY)
        {
            for (int y = 0; y < front.Height; y++)
            {
                for (int x = 0; x < backgroud.Width; x++)
                {
                    if (front.GetPixel(x, y).A < 255)
                    {
                        Color color = backgroud.GetPixel(x + positionX, y + positionY);
                    }
                }
            }
        }

        public static void Blend(PictureBox boxA, PictureBox boxB)
        {
            int left = Math.Abs(boxA.Left - boxB.Left);
            int top = Math.Abs(boxA.Top - boxB.Top);
            Blend((Bitmap)boxA.Image, (Bitmap)boxB.Image, left, top);
        }
    }
}
