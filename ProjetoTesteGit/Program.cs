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
            // 'git clean -df' : Comando para descartar as modificações e voltar pro último commit feito (1/2).
            // 'git checkout -- .' : Comando para descartar as modificações e voltar pro último commit feito (2/2).
            // 'git checkout código do commit/nome do branch' : Comando para navegar entre os commits
            // 'git remote add apelidoDoRep https://linkDoRepGit.com' : Associar repositório local (git) com o remoto (github).
            // 'git remote set-url nomeDoRep https://linkDoRepGit.com' : Associar um repositório local a um outro repositório remoto, porém mantendo o mesmo apelido.
            // 'git push -u apelidoDoRep nomeDaBranch' : Dá um push para o repositório remoto pela primeira vez.
            // 'git push' : Dá um 'push' no branch master para o repositório remoto.
            // 'git clone https://linkDoRepGit.com' : Clona o repositório remoto junto com seu histórico de commits. (Baixar o arquivo diretamente do github não traz os seus commits).
            // 'git pull origin master' : Sincroniza/atualiza o repositório remoto com o local.

            Console.WriteLine("Hello World");
            Console.WriteLine("bom dia");

            Console.WriteLine("Mensagem");
            Console.ReadLine();
        }
    }
}
