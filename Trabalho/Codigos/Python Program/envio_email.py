import smtplib
from email.mime.multipart import MIMEMultipart
from email.mime.text import MIMEText

# Configurações do servidor SMTP do Gmail
smtp_server = "smtp.gmail.com"  # Servidor SMTP do Gmail
smtp_port = 587  # Porta SMTP para TLS
email_usuario = "lopiu15963@gmail.com"  # Seu e-mail Gmail
email_senha = "kacy uohp duov rmkp"  # Sua senha de aplicativo (caso tenha 2FA ativado)

# Função para enviar o e-mail
def enviar_email():
    destinatario = "matheusmvsj@hotmail.com"  # E-mail do destinatário

    # Criando a mensagem
    msg = MIMEMultipart()
    msg['From'] = email_usuario
    msg['To'] = destinatario
    msg['Subject'] = "Escolha uma Opção"

    # Corpo do e-mail em HTML com botões
    corpo_html = """
    <html>
    <head>
        <style>
            .button {
                background-color: #4CAF50;
                color: white;
                padding: 15px 32px;
                text-align: center;
                text-decoration: none;
                display: inline-block;
                font-size: 16px;
                border-radius: 5px;
                cursor: pointer;
            }
            .button:hover {
                background-color: #45a049;
            }
        </style>
    </head>
    <body>
        <p>Olá,</p>
        <p>Por favor, escolha uma das opções abaixo:</p>
        <div>
            <a href="http://www.exemplo.com/opcao1" class="button">Opção 1</a>
            <a href="http://www.exemplo.com/opcao2" class="button">Opção 2</a>
        </div>
        <p>Atenciosamente,<br> Sua Empresa</p>
    </body>
    </html>
    """

    # Anexando o conteúdo HTML ao e-mail
    msg.attach(MIMEText(corpo_html, 'html'))

    # Enviando o e-mail
    try:
        server = smtplib.SMTP(smtp_server, smtp_port)
        server.starttls()  # Iniciar TLS para segurança
        server.login(email_usuario, email_senha)  # Realizando o login
        server.sendmail(email_usuario, destinatario, msg.as_string())  # Enviando o e-mail
        print("E-mail enviado com sucesso para", destinatario)
    except Exception as e:
        print(f"Erro ao enviar e-mail: {e}")
    finally:
        server.quit()

# Enviando o e-mail para matheusmvsj@hotmail.com
enviar_email()
