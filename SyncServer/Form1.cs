using System.IO.Pipes;
using System.Text;
using System;
using System.Windows.Forms;

namespace SyncServer
{
   public partial class Form1 : Form
   {
      private NamedPipeServerStream _server;

      public Form1()
      {
         InitializeComponent();
      }

      private void ButtonStart_Click(object sender, System.EventArgs e)
      {
         // Блокируем кнопку на время работы сервера
         ButtonStart.Enabled = false;
         textBoxLog.Clear();

         Log("Сервер запущен, ожидание подключения...");

         // Создаём серверный канал (одно подключение, режим сообщений)
         using (NamedPipeServerStream server = new NamedPipeServerStream("mypipe", PipeDirection.InOut, 1, PipeTransmissionMode.Message))
         {
            try
            {
               // Синхронное ожидание подключения – UI блокируется до подключения клиента
               server.WaitForConnection();
               Log("Клиент подключён");

               // Чтение сообщения от клиента
               byte[] buffer = new byte[1024];
               int bytesRead = server.Read(buffer, 0, buffer.Length);
               string clientMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
               Log(string.Format("Получено от клиента: {0}", clientMessage));

               // Отправка ответа клиенту
               string reply = string.Format("Сервер получил: \"{0}\"", clientMessage);
               byte[] replyBytes = Encoding.UTF8.GetBytes(reply);
               server.Write(replyBytes, 0, replyBytes.Length);
               Log(string.Format("Отправлено клиенту: {0}", reply));

               // (Опционально) можно прочитать подтверждение от клиента, если нужно
               // Здесь для простоты обмен завершён
            }
            catch (Exception ex)
            {
               Log(string.Format("Ошибка: {0}", ex.Message));
            }
            finally
            {
               server.Disconnect();
               Log("Канал закрыт");
            }
         }

         Log("Сервер завершил работу");
         ButtonStart.Enabled = true;
      }

      private void ButtonStop_Click(object sender, EventArgs e)
      {
         // Принудительное закрытие (клиент получит исключение, но это единственный способ)
         _server.Close();
         Log("Остановка сервера (принудительно)");
      }

      private void Log(string message)
      {
         textBoxLog.AppendText(string.Format("{0:HH:mm:ss:fff} - {1}{2}", DateTime.Now, message, Environment.NewLine));
      }
   }
}