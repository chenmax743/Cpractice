#include <iostream>
#include <stdlib.h>
#include <time.h>
using namespace std;

void shuffle(int n, int A[])
{
    for (int i = 0; i < n * 100; i++) {
        int x = rand() % n;
        int y = rand() % n;
        int tmp = A[x];
        A[x] = A[y];
        A[y] = tmp;
    }
}

int main()
{
    srand(time(NULL));
    int A[] = {1, 2, 3, 4, 5, 6, 7, 8, 9};
    int times = 0, n = 9, x;
    shuffle(n, A);

    cout << "前四個數字已經打亂，請猜測這些數字。" << endl;
    for (int i = 0; i < 4; i++) {
        cout << A[i];
    }
    cout << endl; // 加上?行符以分隔?出

    while (true) {
        cin >> x;
        times += 1;
        int a = 0, b = 0;
        int B[] = {x / 1000, (x % 1000) / 100, (x % 100) / 10, x % 10};
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {
                if (A[i] == B[j] && i != j) b += 1;
                if (A[i] == B[j] && i == j) a += 1;
            }
        }
        cout << a << 'A' << b << 'B' << endl;
        if (a == 4) {
            cout << "您猜對了，共猜了" << times << "次" << endl;
            break;
        }
    }
    return 0;
}

