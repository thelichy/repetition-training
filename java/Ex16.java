import java.util.Scanner;

public class Ex16 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int size = scanner.nextInt();

/*
        for (int i = 0; i <= size; i++) {
            for (int j = size; j > i; j--) {
                System.out.print("! ");
            }
            for (int k = 0; k < i; k++) {
                System.out.print("* ");
            }
            System.out.println();
        }
*/

        for (int i = size; i > 0; i--) {
            for (int k = 1; k <= size; k++) {
                if (k >= i) {
                    System.out.print("* ");
                } else {
                    System.out.print("  ");
                }
            }
            System.out.println();
        }

        scanner.close();
    }
}
