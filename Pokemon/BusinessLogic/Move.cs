using Windows.System;
using System.Collections.Generic;
using Windows.Storage;


//Sofia Avancena

namespace Pokemon.BusinessLogic
{
    class Move
    {
		/* Read only properties */
		private string _moveName;
        public string MoveName
		{
			get { return _moveName; }
		}
        private string _moveType;
        public string MoveType
        {
            get { return _moveType; }
        }
        private int _moveAccuracy;
        public int MoveAccuracy
        {
            get { return _moveAccuracy; }
        }
        private int _movePower;
        public int MovePower
        {
            get { return _movePower; }
        }

        public Move(string name, string type, int accuracy, int power)
        {
            this._moveName = name;
            this._moveType = type;
            this._moveAccuracy = accuracy;
            this._movePower = power;
        }

    }
}
