import java.util.Scanner;

public class Ex03 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int limit = scanner.nextInt();
        for (int i = 1; i < limit; i += 2) {
            System.out.print(i + " ");
        }

        scanner.close();
    }
}
