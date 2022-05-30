using System;
namespace Bridge
{
    public abstract class Programmer
    {
        private string completeMessage = "Создан исполнительный файл";

        Language language;
        public Programmer(Language language, string completeMessage = "Создан исполнительный файл")
        {
            this.language = language;
            this.completeMessage = completeMessage;
    }
        
        State state;

        public void requestProject()
        {
            state = State.Recieved;
        }

        public void completeProject()
        {
            state = State.Complete;
        }

        string getState()
        {
            switch(state)
            {
                case State.Recieved:    return "Заказ принят";
                case State.Complete:    return completeMessage;
                default:                return "Состояние отсутствует";
            }
        }

        string getLanguage()
        {
            return language.name;
        }

        public string getInfo() { return $"Программист: {getLanguage()}/Состояние проекта {getState()}"; }
    }

    enum State
    {
        Recieved = 0,
        Complete = 1
    }
}

