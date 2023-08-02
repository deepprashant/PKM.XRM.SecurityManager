using PKM.XRM.SecurityManager.UI.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKM.XRM.SecurityManager.UI.Presenter
{
    public class BasePresenter
    {
        public void RunAsync(string message, Action actionToCall, Action successAction, Action<AggregateException> errorAction = null)
        {
            string error = string.Empty;
            ModelDialogView view = new ModelDialogView();
            view.ShowMessage = message;
            var threadParametersShow = new ThreadStart(delegate { ShowDialogAsync(view); });
            (new System.Threading.Thread(threadParametersShow)).Start();
            var actionTask = Task.Factory.StartNew(
                () =>
                {
                    actionToCall();
                }).ContinueWith(
                (a) =>
                {
                    var threadParametersHide = new ThreadStart(delegate { HideDialogAsync(view); });
                    (new System.Threading.Thread(threadParametersHide)).Start();
                    if (a.Exception != null)
                        errorAction?.Invoke(a.Exception);
                });



            actionTask.Wait();
            if (string.IsNullOrWhiteSpace(error))
                successAction?.Invoke();
        }

        public void ShowErrorMessage(AggregateException error)
        {
            StringBuilder message = new StringBuilder();
            message.Append(error.Message);
            int count = 0;
            foreach (Exception e in error.InnerExceptions)
            {
                count++;
                message.AppendLine();
                message.Append($"{count}: {e.Message}");
            }

            MessageBox.Show(message.ToString());
        }

        private void ShowDialogAsync(ModelDialogView view)
        {
            if (view.InvokeRequired)
            {
                Action safeDialogOpener = delegate { ShowDialogAsync(view); };
                view.Invoke(safeDialogOpener);
            }
            else
            {
                view.ShowDialog();
            }
        }

        private void HideDialogAsync(ModelDialogView view)
        {
            if (view.InvokeRequired)
            {
                Action safeDialogOpener = delegate { HideDialogAsync(view); };
                view.Invoke(safeDialogOpener);
            }
            else
            {
                view.CloseDialog();
                //view.BeginInvoke(new MethodInvoker(view.CloseDialog));
            }
        }
    }
}
