using System;
namespace Week5
{
    public class Shape
    {   //protect 是指的说，variable不仅可以在自己的class里面，也可以在子类使用
        protected  int width;
        protected int height;
        public void setWidth(int width) {

            this.width = width;


        }
        public int getWidth() {
            return width;

        }
        public void setHeight(int height) {
            this.height = height;

        }
        public int getHeight()
        {
            return height;

        }
    }
}
