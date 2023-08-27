import java.util.Scanner;

public class Ex07 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int start = scanner.nextInt();
        start = start % 2 == 0 ? start - 1 : start;

        for (int i = 1; start >= i; start -= 2) {
            System.out.print(start + " ");
        }

        scanner.close();
    }
}
