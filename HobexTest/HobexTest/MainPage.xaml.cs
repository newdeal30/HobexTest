using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HobexTest {
	public partial class MainPage : ContentPage {

		private Hobex.ECR.Terminal.Tecs.TecsClient _terminal;
		private bool _isDisposed = false;
		private const string _host = "localhost";
		private const int _port = 9990;
		private const bool _isSSL = false;
		private const int _timeout = 180000;
		private Hobex.ECR.Terminal.Response _lastTransaction;
		private HobexLogger _loggerHobex;

    private const string _terminalId = "3600020";
    //private const string _terminalPwd = "12345678";
    private const string _terminalPwd = "";

    public MainPage() {
			InitializeComponent();
		}

		private async void Button_Clicked(object sender, EventArgs e) {
      try {
        await InitTerminalAsync();
        _lastTransaction = _terminal.Purchase(1.50);
      }
      catch (Exception ex) {
        Console.WriteLine(ex.Message);
			}
    }

    private async Task<bool> InitTerminalAsync() {
      try {
        if (_loggerHobex == null) {
          _loggerHobex = new HobexLogger();
          Hobex.ECR.Terminal.Logger.LogManager.SetLogger(_loggerHobex);
        }
        _terminal = new Hobex.ECR.Terminal.Tecs.TecsClient(_terminalId, _terminalPwd, _host, _port, _timeout, _isSSL, "DE");
        _terminal.TerminalCallback += _terminal_TerminalCallback;
        return true;
      }
      catch (Exception) {
        return false;
      }
    }

    private void _terminal_TerminalCallback(object sender, Hobex.ECR.Terminal.InfoEventArgs info) {
      //OnStatus?.Invoke(info.Message);
    }
  }

  public class HobexLogger : Hobex.ECR.Terminal.Logger.ILogger {
    public HobexLogger() {
      //_logger = logger;
    }

    public void Debug(object message) {
      //_logger.Debug($"[HOBEX] {message}", false);
    }

    public void Debug(object message, Exception exception) {
      //_logger.Error(exception, $"[HOBEX] {message}", false);
    }

    public void DebugFormat(string format, object arg0) {
      //_logger.Debug(string.Format($"[HOBEX] {format}", arg0), false);
    }

    public void DebugFormat(string format, params object[] args) {
      //_logger.Debug(string.Format($"[HOBEX] {format}", args), false);
    }

    public void DebugFormat(IFormatProvider provider, string format, params object[] args) {
      //_logger.Debug(string.Format($"[HOBEX] {format}", args), false);
    }

    public void DebugFormat(string format, object arg0, object arg1) {
      //_logger.Debug(string.Format($"[HOBEX] {format}", arg0, arg1), false);
    }

    public void DebugFormat(string format, object arg0, object arg1, object arg2) {
      //_logger.Debug(string.Format($"[HOBEX] {format}", arg0, arg1, arg2), false);
    }

    public void Error(object message) {
      try {
        //_logger.Error(null, $"[HOBEX] {message}", false);
      }
      catch {
      }
    }

    public void Error(object message, Exception exception) {
      //_logger.Error(exception, $"[HOBEX] {message}", false);
    }

    public void ErrorFormat(string format, object arg0) {
      try {
        //_logger.Error(null, string.Format($"[HOBEX] {format}", arg0), false);
      }
      catch {
      }
    }

    public void ErrorFormat(string format, params object[] args) {
      try {
        //_logger.Error(null, string.Format($"[HOBEX] {format}", args), false);
      }
      catch {
      }
    }

    public void ErrorFormat(IFormatProvider provider, string format, params object[] args) {
      try {
        //_logger.Error(null, string.Format($"[HOBEX] {format}", args), false);
      }
      catch {
      }
    }

    public void ErrorFormat(string format, object arg0, object arg1) {
      try {
        //_logger.Error(null, string.Format($"[HOBEX] {format}", arg0, arg1), false);
      }
      catch {
      }
    }

    public void ErrorFormat(string format, object arg0, object arg1, object arg2) {
      try {
        //_logger.Error(null, string.Format($"[HOBEX] {format}", arg0, arg1, arg2), false);
      }
      catch {
      }
    }

    public void Fatal(object message) {
      try {
        //_logger.Fatal(null, $"[HOBEX] {message}", false);
      }
      catch {
      }
    }

    public void Fatal(object message, Exception exception) {
      //_logger.Fatal(exception, $"[HOBEX] {message}", false);
    }

    public void FatalFormat(string format, object arg0) {
      try {
        //_logger.Fatal(null, string.Format($"[HOBEX] {format}", arg0), false);
      }
      catch {
      }
    }

    public void FatalFormat(string format, params object[] args) {
      try {
        //_logger.Fatal(null, string.Format($"[HOBEX] {format}", args), false);
      }
      catch {
      }
    }

    public void FatalFormat(IFormatProvider provider, string format, params object[] args) {
      try {
        //_logger.Fatal(null, string.Format($"[HOBEX] {format}", args), false);
      }
      catch {
      }
    }

    public void FatalFormat(string format, object arg0, object arg1) {
      try {
        //_logger.Fatal(null, string.Format($"[HOBEX] {format}", arg0, arg1), false);
      }
      catch {
      }
    }

    public void FatalFormat(string format, object arg0, object arg1, object arg2) {
      try {
        //_logger.Fatal(null, string.Format($"[HOBEX] {format}", arg0, arg1, arg2), false);
      }
      catch {
      }
    }

    public void Info(object message) {
      //_logger.Info(message.ToString(), false);
    }

    public void Info(object message, Exception exception) {
      //_logger.Info($"[HOBEX] {message} {(exception != null ? exception.Message : string.Empty)}", false);
    }

    public void InfoFormat(string format, object arg0) {
      //_logger.Info(string.Format($"[HOBEX] {format}", arg0), false);
    }

    public void InfoFormat(string format, params object[] args) {
      //_logger.Info(string.Format($"[HOBEX] {format}", args), false);
    }

    public void InfoFormat(IFormatProvider provider, string format, params object[] args) {
      //_logger.Info(string.Format($"[HOBEX] {format}", args), false);
    }

    public void InfoFormat(string format, object arg0, object arg1) {
      //_logger.Info(string.Format($"[HOBEX] {format}", arg0, arg1), false);
    }

    public void InfoFormat(string format, object arg0, object arg1, object arg2) {
      //_logger.Info(string.Format($"[HOBEX] {format}", arg0, arg1, arg2), false);
    }

    public void Warn(object message) {
      //_logger.Warn($"[HOBEX] {message}", false);
    }

    public void Warn(object message, Exception exception) {
      //_logger.Warn($"[HOBEX] {message} {(exception != null ? exception.Message : string.Empty)}", false);
    }

    public void WarnFormat(string format, object arg0) {
      //_logger.Warn(string.Format($"[HOBEX] {format}", arg0), false);
    }

    public void WarnFormat(string format, params object[] args) {
      //_logger.Warn(string.Format($"[HOBEX] {format}", args), false);
    }

    public void WarnFormat(IFormatProvider provider, string format, params object[] args) {
      //_logger.Warn(string.Format($"[HOBEX] {format}", args), false);
    }

    public void WarnFormat(string format, object arg0, object arg1) {
      //_logger.Warn(string.Format($"[HOBEX] {format}", arg0, arg1), false);
    }

    public void WarnFormat(string format, object arg0, object arg1, object arg2) {
      //_logger.Warn(string.Format($"[HOBEX] {format}", arg0, arg1, arg2), false);
    }
  }

}
