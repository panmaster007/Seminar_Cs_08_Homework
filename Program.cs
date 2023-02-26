﻿// Начало кода
void TaskMenu()
{
	bool exitOut = true;

	while (exitOut == true)
	{
		Console.WriteLine("Введите номер задачи(54, 56, 58, 60 либо q/Q для выхода):");
		string selectTask = "";
		selectTask = Console.ReadLine();

		switch (selectTask)
		{
			case "54":
				{
					Console.Clear();
					Task_54();
					break;
				}

			case "56":
				{
					Console.Clear();
					Task_56();
					break;
				}

			case "58":
				{
					Console.Clear();
					Task_58();
					break;
				}

			case "60":
				{
					Console.Clear();
					Task_60();
					break;
				}

			case "q":
				{
					exitOut = false;
					Console.Clear();
					break;
				}

			case "Q":
				{
					exitOut = false;
					Console.Clear();
					break;
				}

			default:
				{
					Console.WriteLine("Вы не попали в нужную кнопку, попробуйте ещё разок!");
					break;
				}
		}
	}
}

// здесь располагаем методы для выполнения всех наших задач
void FillingTwoDimensionArrayInt(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = new Random().Next(0, 10);
		}
	}
}

void PrintTwoDimensionArrayToStringInt(int[,] array)
{
	string result = string.Empty; // "";

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			System.Console.Write($"{array[i, j]} ");
		}
		System.Console.WriteLine();
	}
}

void ResortingRowArrayElements(int[,] array)
{
	int temp = 0;

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			for (int n = 0; n < array.GetLength(1) - 1; n++)
				if (array[i, n + 1] > array[i, n])
				{
					temp = array[i, n];
					array[i, n] = array[i, n + 1];
					array[i, n + 1] = temp;
				}
		}
	}
}

void FindMinSum(int[,] array)
{
	int minSum = int.MaxValue;
	int index = 0;

	for (int i = 0; i < array.GetLength(0); i++)
	{
		int rowSum = 0;

		for (int j = 0; j < array.GetLength(1); j++)
		{
			rowSum += array[i, j];
		}

		if (minSum > rowSum)
		{
			minSum = rowSum;
			index = i;
		}
	}

	Console.WriteLine($"В {index + 1} строке минимальная сумма");
}

int[,] MultMatr(int[,] matA, int[,] matB, int[,] matC)
{
	for (int i = 0; i < matC.GetLength(0); i++)
	{
		for (int j = 0; j < matC.GetLength(1); j++)
		{
			int sum = 0;
			for (int k = 0; k < matA.GetLength(0); k++)
			{
				sum = sum + matA[i, k] * matB[k, j];
			}
			matC[i, j] = sum;
		}
	}
	return matC;
}

void FillingArrayRandomUnique(int[] array)
{
	Random random = new Random();

	for (int i = 0; i < array.GetLength(0); i++)
	{
		bool isUnic = false;

		while (!isUnic)
		{
			array[i] = random.Next(10, 100);

			if (CheckUniques(array, i))
			{
				isUnic = true;
			}
		}
	}
}

bool CheckUniques(int[] array, int i)
{
	for (int j = 0; j < i; j++)
	{
		if (i == 0)
		{
			return true;
		}
		else if (array[i] == array[j])
		{
			return false;
		}
	}

	return true;
}

void OneToThreeDimensionArray(int[,,] array, int[] tempArray)
{
	int l = 0;

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			for (int k = 0; k < array.GetLength(2); k++)
			{
				array[i, j, k] = tempArray[l++];
			}
		}
	}
}

void PrintThreeDimensionArrayToInt(int[,,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			for (int k = 0; k < array.GetLength(2); k++)
			{
				Console.WriteLine($"{array[i, j, k]}({i}, {j}, {k})");
			}
		}
	}
}

	void Task_54()
	{
		// Здесь вызываем необходимые методы для выполнения 54-й задачи
		int[,] array = new int[3, 4];
		FillingTwoDimensionArrayInt(array);
		PrintTwoDimensionArrayToStringInt(array);
		ResortingRowArrayElements(array);
		System.Console.WriteLine();
		PrintTwoDimensionArrayToStringInt(array);
	}

	void Task_56()
	{
		// Здесь вызываем необходимые методы для выполнения 56-й задачи
		int[,] array = new int[7, 4];
		FillingTwoDimensionArrayInt(array);
		PrintTwoDimensionArrayToStringInt(array);
		System.Console.WriteLine();
		FindMinSum(array);
	}

	void Task_58()
	{
		// Здесь вызываем необходимые методы для выполнения 58-й задачи
		int[,] matA = new int[2, 2];
		int[,] matB = new int[2, 2];
		int[,] matC = new int[2, 2];
		FillingTwoDimensionArrayInt(matA);
		FillingTwoDimensionArrayInt(matB);
		matC = MultMatr(matA, matB, matC);
		Console.WriteLine($"Матрица А: ");
		PrintTwoDimensionArrayToStringInt(matA);
		Console.WriteLine($"Матрица Б: ");
		PrintTwoDimensionArrayToStringInt(matB);
		Console.WriteLine($"Матрица С: ");
		PrintTwoDimensionArrayToStringInt(matC);
	}

	void Task_60()
	{
		// Здесь вызываем необходимые методы для выполнения 60-й задачи
		int[] tempArray = new int[8];
		int[,,] array = new int[2, 2, 2];
		FillingArrayRandomUnique(tempArray);
		System.Console.WriteLine();
		OneToThreeDimensionArray(array, tempArray);
		PrintThreeDimensionArrayToInt(array);
	}

	TaskMenu();