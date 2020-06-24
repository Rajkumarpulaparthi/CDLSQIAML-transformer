using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aml.Editor.Plugin
{
    public class CDLSQIcontroller
    {
        private CDLSQIUserInterface cDLSQIUserInterface;

        private CDLSQIamltransformer cDLSQIamltransformer;

        /// <summary>
        /// Init the controller and reload all amlx devices
        /// </summary>
        /// <param name="cDLSQItransformer"></param>

        public CDLSQIcontroller(CDLSQIamltransformer cDLSQIamltransformer)
        {
            this.cDLSQIamltransformer = cDLSQIamltransformer;
        }


        /// <summary>
        /// Create the new CDLSQItransformer GUI or return the previously created GUI
        /// </summary>
        /// <returns>the CDLSQItransformer GUI for this session</returns>

        /// <summary>
        /// creáte the new CDLSQItransformer GUI or return the previously created GUI
        /// </summary>
        public CDLSQIUserInterface GetUserControlForm()
        {
            if (cDLSQIUserInterface == null)
            {
                cDLSQIUserInterface = new CDLSQIUserInterface(this);
            }
            return cDLSQIUserInterface;
        }

        /// <summary>
        /// Switch the displayed 
        /// </summary>
        /// <param name="targetGUI">the GUI Type to display</param>
        public void ChangeGui(GUIType targetGUI)
        {
            switch (targetGUI)
            {

                case GUIType.cDLSQIUserInterface:
                    cDLSQIamltransformer.changeGUI(GetUserControlForm());
                    break;

            }
        }

        /// <summary>
        /// Enum to represent the GUI
        /// </summary>
        public enum GUIType { Start, cDLSQIUserInterface }
    }
}
