using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LGroup.MVVM.ViewModel
{

    //Para manipilar o evento click
    //Utilizamos a interface ICOMMAND
    //Essa classe captura os clicks
    //E roda os métodos
    public sealed class DispararClick : ICommand
    {
        //criamos um DELEGATE DO TIPO ACTION
        //PARA FAZER OS CALLBACKS (CHAMADAS DE RETORNO)
        //Redirecionamentos oara os comandos de Limpar e cadastrar
        //Delegates sao referencias de memoria
        //Apontadores levam para um determinado MÉTODO
        //Conseguimos armazenar método em variaveis, memoria
        //Para pode acionálos futuramente
        //Delegates (Action, Func, Predicate)
        //Threads (Semaphores, Monitores, Mutex)
        
        //A action vai receber um método (limpar, cadastrar)
        //Delegate, é ele quem vai acionar os comandos

        private Action _metodo;
        public DispararClick(Action metodo_)
        {
            _metodo = metodo_;
        }
        public bool CanExecute(object parameter)
        {
            //para habilitar o ou desabilitar os botoes
            //Os botoes das telass TRUE => Habilita, FALSE => Desabilita
            return true;
        }

        public event EventHandler CanExecuteChanged;
        
        //esse metodo serve para disparar o 
        //o comando que recebemos via construtor
        public void Execute(object parameter)
        {
            //Acionamos o limpar ou cadastrar
            _metodo();
        }
    }
}
