using System.Collections;
using System.Windows.Forms;

namespace ATMT
{
    public class Element
    {
        private static int noElement;
        private int id;
        private int type;
        private PictureBox pictureBox;
        private ArrayList internalElementList;
        private ArrayList externalElementList;

        public Element()
        {
            id = noElement++;
            internalElementList = new ArrayList();
            externalElementList = new ArrayList();
        }

        public static void clearElementId()
        {
            noElement = 0;
        }

        public int getId()
        {
            return id;
        }

        public int getType()
        {
            return this.type;
        }

        public void setType(int type)
        {
            this.type = type;
        }

        public PictureBox getPictureBox()
        {
            return this.pictureBox;
        }

        public void setPictureBox(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
        }

        public ArrayList getInternalElementList()
        {
            return this.internalElementList;
        }

        public void addInternalElementList(Element element)
        {
            if (!internalElementList.Contains(element))
            {
                this.internalElementList.Add(element);
            }
        }

        public ArrayList getExternalElementList()
        {
            return this.externalElementList;
        }

        public void addExternalElementList(Element element)
        {
            if (!externalElementList.Contains(element))
            {
                this.externalElementList.Add(element);
            }
        }
    }
}