import java.util.Scanner;

public class Ex24 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        StringBuilder rst = new StringBuilder();
        int size = scanner.nextInt();

        for (int i = 0, c = 1; i <= size; i++) {
            for (int j = 0; j < i; j++) {
                rst.append(c).append(" ");
                c++;
            }
            rst.append("\n");
        }

        System.out.println(rst);
    }
}
