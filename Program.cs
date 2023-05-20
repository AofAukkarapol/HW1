using System;

class Program {
    static void Main(string[] args) {
        int rowNum;
        while (true) {
            Console.Write("Enter a row number for Pascal's Triangle: ");
            rowNum = Convert.ToInt32(Console.ReadLine());

            if (rowNum >= 0) {
                break;
            }

            Console.WriteLine("Invalid Pascal's triangle row number.");
        }

        int[] row = { 1 };
        Console.WriteLine(row[0]);

        for (int i = 1; i <= rowNum; i++) {
            int[] newRow = new int[i+1];
            newRow[0] = 1;
            newRow[i] = 1;
            for (int j = 1; j < i; j++) {
                newRow[j] = row[j-1] + row[j];
            }
            row = newRow;
            for (int j = 0; j <= i; j++) {
                Console.Write(row[j] + " ");
            }
            Console.WriteLine();
        }
    }
}
