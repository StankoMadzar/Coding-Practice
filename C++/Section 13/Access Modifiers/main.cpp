#include <iostream> 
#include <string> 

using namespace std;

class Player{
private:
    string name {"Player"};
    int health;
    int xp;
public:
    void talk(string text_to_say) { cout << name << " says " << text_to_say << endl;}
};

int main() {

    Player frank;
    frank.talk("hello there");

    return 0;
}