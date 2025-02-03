namespace StatePatternExample
{
    public interface IATMState
    {
        void InsertCard(ATMContext context);
        void EnterPin(ATMContext context);
        void WithdrawMoney(ATMContext context);
    }

    public class NoCardState : IATMState
    {
        public void InsertCard(ATMContext context)
        {
            Console.WriteLine("Carte insérée. Veuillez entrer votre code PIN.");
            context.SetState(new HasCardState());
        }

        public void EnterPin(ATMContext context)
        {
            Console.WriteLine("Vous devez d'abord insérer une carte.");
        }

        public void WithdrawMoney(ATMContext context)
        {
            Console.WriteLine("Vous devez d'abord insérer une carte.");
        }
    }

    public class HasCardState : IATMState
    {
        public void InsertCard(ATMContext context)
        {
            Console.WriteLine("Carte déjà insérée.");
        }

        public void EnterPin(ATMContext context)
        {
            Console.WriteLine("Code PIN correct. Vous pouvez retirer de l'argent.");
            context.SetState(new PinVerifiedState());
        }

        public void WithdrawMoney(ATMContext context)
        {
            Console.WriteLine("Veuillez d'abord entrer votre code PIN.");
        }
    }

    public class PinVerifiedState : IATMState
    {
        public void InsertCard(ATMContext context)
        {
            Console.WriteLine("Une carte est déjà insérée.");
        }

        public void EnterPin(ATMContext context)
        {
            Console.WriteLine("Code déjà validé.");
        }

        public void WithdrawMoney(ATMContext context)
        {
            Console.WriteLine("Retrait en cours... Retirez votre argent.");
            context.SetState(new NoCardState()); // Retour à l'état initial
        }
    }

    public class ATMContext
    {
        private IATMState _currentState;

        public ATMContext()
        {
            _currentState = new NoCardState(); // État initial
        }

        public void SetState(IATMState newState)
        {
            _currentState = newState;
        }

        public void InsertCard() => _currentState.InsertCard(this);
        public void EnterPin() => _currentState.EnterPin(this);
        public void WithdrawMoney() => _currentState.WithdrawMoney(this);
    }

    class Program
    {
        static void Main()
        {
            var atm = new ATMContext();

            atm.WithdrawMoney(); // Erreur : Insérer une carte d'abord
            atm.EnterPin(); // Erreur : Insérer une carte d'abord

            atm.InsertCard(); // Transition vers HasCardState
            atm.EnterPin(); // Transition vers PinVerifiedState

            atm.WithdrawMoney(); // Retrait réussi, retour à NoCardState

            atm.WithdrawMoney(); // Erreur : Insérer une carte d'abord
        }
    }


}
