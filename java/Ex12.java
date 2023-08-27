import java.util.Scanner;

public class Ex12 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int size = scanner.nextInt();
        for (int i = 0; i < size; i++) {
            System.out.print("* ");
        }

        scanner.close();
    }
}
