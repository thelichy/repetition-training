import java.util.Scanner;

public class Ex01 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int limit = scanner.nextInt();
        for (int i = 1; i <= limit; i++) {
            System.out.print(i + " ");
        }

        scanner.close();
    }
}
