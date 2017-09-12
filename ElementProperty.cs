using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ATMT
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class AttackLibrary
    {
        [Browsable(false)]
        public string caption { get; set; }

        [DisplayName("Type"), ReadOnly(true)]
        public string type { get; set; }

        [DisplayName("Description"), ReadOnly(true)]
        public string description { get; set; }

        [DisplayName("Attack Method"), ReadOnly(true)]
        public string attackMethod { get; set; }

        [DisplayName("Recommendation"), ReadOnly(true)]
        public string recommendation { get; set; }

        public override string ToString()
        {
            return caption;
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ElementProperty
    {
        [Category("Threats"), DisplayName("Threat List"), ReadOnly(true)]
        public AttackLibrary[] attackLibraryList { get; set; }
    }
}