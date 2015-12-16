﻿
namespace Ink.Runtime
{
	public class ChoiceInstance : Runtime.Object
	{
        public string choiceText { get; set; }

        internal bool hasBeenChosen { get; set; }
		internal Choice choice { get; private set; }
        internal CallStack.Thread threadAtGeneration { get; set; }

        public ChoiceInstance()
        {
        }

		internal ChoiceInstance (Choice choice)
		{
			this.choice = choice;
		}

	}
}

