using LGroup.MVVM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

//O padrao MVVM existe desde 2005 
//Criado pela Microsoft
//É um padrao utilizado em tecnologias baseadas em XAML
//WPF, XBAP, WINDOWS PHONE, SILVERLIGHT, XAMARIN
//Model -> Armazenamento
//View -> Interface
//ViewModel -> Programação da tela (Eventos, mensagens)

//MODEL -> Armazena dados que vao ou vem da tabela
//VIEWMODEL -> Dados que vem ou vao da tela
//Aqui no XAML temos 3 técnicas especificas, exclusivas
//BINDING (Sincronizacao de dados)
//COMMAND (Eventos, Cliques de botoes)
//NOTIFICATION (Notificacao, SInal para tela) -=> Recarregar dados
namespace LGroup.MVVM.ViewModel.Modulos.Clientes
{

    //Cada tela vai ter o seu VIEW Model
    //VIEW = 1 VIEWMODEL
    //para cada campo da view = 1 propriedade no ViewModel
    //o XAML é compilado e vira BAML (XAML Binário)
    //Xaml é compilado e tem verificacao de sintaxe


    //A interface abaixo serve para enviar notificacoes para a tela
    //avisando que os campos foram alterados 
    public sealed class CadastrarViewModel : INotifyPropertyChanged
    {
        public CadastrarViewModel()
        {
            //Fizemos os redirecionamentos, 
            //Quando os botoes forem disparados via COMMAND, 
            //Redirecionamos para os métodos atraves da 
            //Classe de redirecionamento
            //BOTAO (BINDING) -> COMMAND (CLICKLIMPAR) -> DISPARARCLICK (ICOMMAND) -> DELEGATE (MÉTODOS)

            ClickLimpar = new DispararClick(Limpar);
            ClickCadastrar = new DispararClick(Cadastrar);
        }
        private String _nome;

        public String Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Nome"));
            }
        }
        private String _email;

        public String Email
        {
            get { return _email; }
            set
            {
                _email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        private String _telefone;

        public String Telefone
        {
            get { return _telefone; }
            set
            {
                _telefone = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Telefone"));
            }
        }

        private DateTime? _dataNascimento;

        public DateTime? DataNascimento
        {
            get { return _dataNascimento; }
            set
            {
                _dataNascimento = value;
                PropertyChanged(this, new PropertyChangedEventArgs("DataNascimento"));
            }
        }

        //para pegar o clique dos botoes, temos que utilizar
        //a técnica de COMMAND (Comandos) = Eventos
        //Métodos não funcionam para fazer binding, só da pra fazer binding em propriedades
        //para pegar os cliques, obrigatoriamente temos que
        //utilizar a interface ICommand
        //BOTAO (BINDING) (COMMAND = CLICKLIMPAR)
        //Os  métodos tem que dispararr os métodos la em baixo
        //ICOMMAND é como se fosse um evento
        public ICommand ClickLimpar { get; set; }
        public ICommand ClickCadastrar { get; set; }
        //public Command MyProperty { get; set; }
        //Criamos 2 méotodos, 1 para cada botao da tela
        //Toda programacao em C# da tela fica no VIEWMODEL

        public void Limpar()
        {
            //Limpamos os dados da Tela
            //Para que a tela seja mudada, precisamos notificar a view para ser alterada
            Nome = String.Empty;
            Email = String.Empty;
            Telefone = String.Empty;
            DataNascimento = null;
        }
        public void Cadastrar()
        {
            //Pegamos os dados do ViewModel
            //E salvamos no Model

            var novoCliente = new ClienteModel
            {
                Nome = Nome,
                Email = Email,
                Telefone = Telefone,
                DataNascimento = DataNascimento

            };


        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
