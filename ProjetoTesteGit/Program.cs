using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteGit
{
    class Program
    {
        //Git: Criando e configurando o controle de versão.
        static void Main(string[] args)
        {
            // Após instalar o 'Git' o primeiro passo é criar uma '.txt' no local do projeto chamado '.gitignore' e pesquisar as coisas que serão ignoradas para colar lá dentro.
            // Após finalizado esse arquivo inicie um 'gitbash' dentro da pasta do projeto para abrir o console. // o comando 'git' irá auxiliar em alguns comandos basicos.
            // 'git init' : Comando para inicializar o controle de versão na pasta é o: 'git init'.
            // 'git config --global user.name "nome"' & 'git config --global user.email "email@.com"' : Comando para configurar o nome e email que fez a alterção no git.
            // 'git status' : Verifica como está o repositório. // cor vermelha = Arquivos não rastreados; Verde: Arquivos pronto para serem commitados (stage).
            // 'git add .' : (sendo o '.' todos os arquivos, também podem ser adicionados somente alguns arquivos.) - Adiciona os arquivos para a área de stage.
            // 'git commit -m "descrição aqui"' : "Commita" os arquivos.
            // 'git log' : Mostra os commits feitos com seus devidos registros.
            // 'git log --oneline' : Mostra os commits resumidos

            Console.WriteLine("Hello World");
            Console.WriteLine("bom dia");

            Console.WriteLine("Mensagem");
            Console.ReadLine();
        }
    }
}
