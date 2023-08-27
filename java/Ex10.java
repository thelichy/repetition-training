import java.util.Scanner;

public class Ex10 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int limit = scanner.nextInt();
        for (int i = 1; i <= limit; i++) {
            System.out.printf("The double of %d is %d\n", i, i * 2);
        }

        scanner.close();
    }
}
