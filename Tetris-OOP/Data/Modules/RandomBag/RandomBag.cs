using System;
using System.Collections.Generic;

namespace Engine
{
	public class RandomBag
	{
		#region Properties

		/// <summary>
		///     linked list of the last four peices that were put into play
		/// </summary>
		public Queue<int> ShapeHistory { get; }

		/// <summary>
		///     The max num that will be returned.
		///     all numbers will be between 0 -> maxnum
		/// </summary>
		public int MaxNum { get; set; }
		public int MinNum { get; set; }

		/// <summary>
		///     The size of the random bag. Bigger bag is less random.
		///     Defaults to 4, which is a good size if you want random numbers between 0-6
		/// </summary>
		public int BagSize { get; set; }

		/// <summary>
		///     The number of times it will retry to get a number that isn't already in the bag before giving up.
		///     Defaults to 4, which is a good size if you want random numbers between 0-6
		/// </summary>
		public int RandomTries { get; set; }

		/// <summary>
		///     A random generator.
		/// </summary>
		private static readonly Random rand = new Random();

		#endregion //Properties

		#region Инициализация

		/// <summary>Конструктор</summary>
		/// <param name="maxNum">Максимальное число</param>
		/// <param name="minNum">Минимальное число</param>
		/// <param name="bagSize">Размер сумки с фигурами (количество фигур)</param>
		/// <param name="randomTries">Количество попыток генерировать новую фигуру, при выпадении одинаковых</param>
		public RandomBag(int minNum, int maxNum, int bagSize = 7, int randomTries = 4)
		{
			MinNum = minNum;
			MaxNum = maxNum;
			BagSize = bagSize;
			RandomTries = randomTries;
			ShapeHistory = new Queue<int>();
		}

		#endregion //Инициализация

		#region Methods

		/// <summary>
		///     Create a random shape.
		/// </summary>
		/// <returns>Tetrad: a pseduo-random tetrad, generated using TGM algorithm</returns>
		public int Next()
		{
			//variable used to store the random piece we come up with.
			var randomShape = 0;

			//try to get a crispy peice 6 times, then give up
			var i = 0;
			while (i < RandomTries)
			{
				//get a random piece
				randomShape = rand.Next(MinNum, MaxNum);

				//Check if that peice has been played recently
				var bFound = false;
				foreach (int num in ShapeHistory)
					if (num == randomShape)
					{
						//crap this peice has been played recently
						bFound = true;
						break;
					}

				//Is this peice ok, or did we find it in the recent history?
				if (bFound)
					i++;
				else
					break;
			}

			//okay, got a new peice, add it to the end of the list and pop off the front
			AddShapeToHistory(randomShape);

			// Return the new shape.
			return randomShape;
		}

		/// <summary>Adds the shape to history.</summary>
		/// <param name="shapeType">Shape type to put in history</param>
		public void AddShapeToHistory(int shapeType)
		{
			ShapeHistory.Enqueue(shapeType);

			//verify the size of the history queue
			while (ShapeHistory.Count > BagSize) ShapeHistory.Dequeue();
		}

		#endregion //Methods
	}
}