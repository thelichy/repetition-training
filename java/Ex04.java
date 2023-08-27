import java.util.Scanner;

public class Ex04 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int start = scanner.nextInt();
        int end = scanner.nextInt();

        for (; start <= end; start++) {
            System.out.print(start + " ");
        }

        scanner.close();
    }
}
