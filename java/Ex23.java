import java.util.Scanner;

public class Ex23 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        StringBuilder rst = new StringBuilder();
        int size = scanner.nextInt();

        for (int i = 0; i <= size; i++) {
            for (int j = 0; j < i; j++) {
                rst.append(i).append(" ");
            }
            rst.append("\n");
        }

        System.out.println(rst);
    }
}
