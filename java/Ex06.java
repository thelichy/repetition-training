import java.util.Scanner;

public class Ex06 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int start = scanner.nextInt();
        start = start % 2 == 0 ? start : start - 1;

        for (int i = 0; start >= i; start -= 2) {
            System.out.print(start + " ");
        }

        scanner.close();
    }
}
