using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly:ExportRenderer(typeof(MyEntry), typeof(MyEnryRenderer))]

namespace CustomEntry
{ 
    public class MyEntryRenderer:EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if(Control != null)
            {

            }
        }

    }
}
