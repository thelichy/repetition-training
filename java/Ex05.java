import java.util.Scanner;

public class Ex05 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int start = scanner.nextInt();
        for (int i = 1; start >= i; start--) {
            System.out.print(start + " ");
        }

        scanner.close();
    }
}
