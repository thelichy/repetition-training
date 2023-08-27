import java.util.Scanner;

public class Ex26 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        StringBuilder rst = new StringBuilder();
        int side = scanner.nextInt() - 1;

        for (int row = 1; row <= side; row++)
        {
            rst.append("  ".repeat(Math.max(0, side - row + 1)));
            for (int i = row; i > 0; i--) rst.append(i).append(" ");
            for (int j = 2; j <= row; j++) rst.append(j).append(" ");
            rst.append("\n");
        }

        System.out.println(rst);
    }
}
