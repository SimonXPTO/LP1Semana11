using System;

namespace GuessTheWord
{
    public class Controller
    {
        private readonly View _view;
        private readonly Model _model;

        public Controller(View _view, Model _model)
        {
            this._view = _view;
            this._model = _model;
        }

        public void Run()
        {
            string guess;
            string chosenWord = _model.ChosenWord;
            do
            {
                _view.ShowWelcome();
                _view.ShowHint(_model.Hint);
                _view.ShowWord(_model.Display);
                guess = _view.GetGuess();

                _view.ShowResult(guess, _model.ChosenWord);

            } while (guess != chosenWord);
            
        }
    }
}
