#include <iostream>
#include <vector>

using namespace std;

int main()
{
    int red[] = {1, 2, 3, 4, 5};
    
    vector<string> stooges {"Larry", "More", "Curly"};
    for (auto covek: stooges)
        covek = "Stanko";
        
    for (auto covek: stooges)
        cout << covek << endl;
    
    for (auto broj: red)
        red[broj] = 1;
        
    for (auto broj: red)
        cout << red[broj] << endl;

    return 0;
}
