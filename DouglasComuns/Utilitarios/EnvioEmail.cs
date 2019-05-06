using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace DouglasComuns.Utilitarios
{
    public class EnvioEmail
    {
        /// <summary>
        /// Montar o Email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static string MontarEmail(DadosEmail email)
        {
            try
            {
                // valida o email de
                bool emailValido = ValidaEnderecoEmail(email.De);

                // Se o email não é validao retorna uma mensagem
                if (emailValido == false)
                    return "Email do remetente inválido:" + email.De;

                // Cria uma mensagem
                MailMessage message = new MailMessage();

                message.From = new MailAddress(email.De);

                foreach (var destinatario in email.Para)
                {
                    // valida o email para
                    emailValido = ValidaEnderecoEmail(destinatario);

                    // Se o email não é validao retorna uma mensagem
                    if (!emailValido)
                        return "Email do destinatário inválido:" + email.Para;

                    message.To.Add(destinatario);
                    message.Bcc.Add(destinatario);
                }

                message.Subject = email.Assunto;
                message.Body = email.Conteudo;

                // Verifica se tem anexos, se sim, envia os anexos
                if (email.Anexos != null)
                {
                    foreach (string anexo in email.Anexos)
                    {
                        message.Attachments.Add(new Attachment(anexo));
                    }
                }

                return EnviarEmail(message);                
            }
            catch (Exception ex)
            {
                string erro = ex.InnerException.ToString();
                return ex.Message.ToString() + erro;
            }
        }

        /// <summary>
        /// Enviar o Email
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private static string EnviarEmail(MailMessage message)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            NetworkCredential cred = new NetworkCredential("SEU_EMAIL@gmail.com", "SUA_SENHA");
            client.Credentials = cred;

            // Inclui as credenciais
            client.UseDefaultCredentials = true;

            // envia a mensagem
            client.Send(message);

            return "Mensagem enviada para " + message.From + " às " + DateTime.Now.ToString() + ".";
        }

        /// <summary>
        /// Validar se Endereço de Email é válido
        /// </summary>
        /// <param name="enderecoEmail"></param>
        /// <returns></returns>
        public static bool ValidaEnderecoEmail(string enderecoEmail)
        {
            //define a expressão regular para validar o email
            string texto_Validar = enderecoEmail;
            Regex expressaoRegex = new Regex(@"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}");

            // testa o email com a expressão
            if (expressaoRegex.IsMatch(texto_Validar)) 
                return true; // o email é valido
            else  
                return false; // o email é inválido
        }
    }

    public class DadosEmail
    {
        public DadosEmail(string de, List<string> para, string assunto, string conteudo, List<String> anexos = null)
        {
            this.De = de;
            this.Para = para;
            this.Assunto = assunto;
            this.Conteudo = conteudo;
            if (anexos != null)
                this.Anexos = anexos;
        }

        public string De { get; set; }
        public List<string> Para { get; set; }
        public string Assunto { get; set; }
        public string Conteudo { get; set; }
        public List<String> Anexos { get; set; }
    }
}
