import java.util.Scanner;

public class Ex22 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        StringBuilder rst = new StringBuilder();
        int side = scanner.nextInt() - 1;

        for (int row = 0; row <= side; row++)
        {
            rst.append("  ".repeat(Math.max(0, side - row)));
            rst.append(" *".repeat(Math.max(0, row)));
            rst.append(" *".repeat(Math.max(0, row + 1)));
            rst.append("\n");
        }
        for (int row = side - 1; row >= 0; row--)
        {
            rst.append("  ".repeat(Math.max(0, side - row)));
            rst.append(" *".repeat(row));
            rst.append(" *".repeat(Math.max(0, row + 1)));
            rst.append("\n");
        }

        System.out.println(rst);
        scanner.close();
    }
}
