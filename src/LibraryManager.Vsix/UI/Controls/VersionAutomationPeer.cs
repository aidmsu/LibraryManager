using System.Windows.Automation.Peers;
using System.Windows.Controls;

namespace Microsoft.Web.LibraryManager.Vsix.UI.Controls
{
    /// <summary>
    /// Custom AutomationPeer for Version control
    /// </summary>
    internal class VersionAutomationPeer : UserControlAutomationPeer
    {
        public VersionAutomationPeer(UserControl owner) : base(owner)
        {
        }

        protected override AutomationControlType GetAutomationControlTypeCore()
        {
            return AutomationControlType.Text;
        }
    }
}
