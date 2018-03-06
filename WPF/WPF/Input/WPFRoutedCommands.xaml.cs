using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF.Input
{
    /// <summary>
    /// WPFRoutedCommands.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class WPFRoutedCommands : Window
    {
        public WPFRoutedCommands()
        {
            InitializeComponent();
            CommandBindings.Add(new CommandBinding(ApplicationCommands.New, NewExecuted, CanNew));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Open, OpenExecuted, CanOpen));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Save, SaveExecuted, CanSave));

            //Focus(); //Context Menu가 동작하지 않기 때문에 Focus() 함수를 사용하여 조치 ( 방안 1)
            /*
             * http://www.wpftutorial.net/RoutedCommandsInContextMenu.html
             * The reason is, that ContextMenus are separate windows with their own VisualTree and LogicalTree.
             * The reason is that the CommandManager searches for CommandBindings within the current focus scope. 
             * If the current focus scope has no command binding, it transfers the focus scope to the parent focus scope. 
             * When you startup your application the focus scope is not set. You can check this by calling FocusManager.GetFocusedElement(this) and you will receive null.
             */
        }

        private void CanSave(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CanOpen(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CanNew(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Save Executed: " + e.Source.GetType().ToString());
        }

        private void OpenExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Open Executed: " + e.Source.GetType().ToString());
        }

        private void NewExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("New Executed: " + e.Source.GetType().ToString());
        }
    }
}
