#include <iostream>
#include "Account.h"

using namespace std;

int main () {
    Account frank_account;
    frank_account.set_name("Frank's account");
    frank_account.set_balance(1000.00);
    
    if (frank_account.deposit(200.0))
        cout << "Deposit OK" << endl;
    else
        cout << "Deposit Failed" << endl;

    if (frank_account.withdraw(500.0))
        cout << "Withdraw OK" << endl;
    else
        cout << "Withdraw Failed" << endl;

    if (frank_account.withdraw(1500.0))
        cout << "Withdraw OK" << endl;
    else
        cout << "Withdraw Failed" << endl;

    return 0;
}