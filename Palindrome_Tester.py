def is_palindrome(input_string):
    return input_string == input_string[::-1]

while True:
    user_input = input("Enter a word to check if it's a palindrome or 'q' to quit: ")
    if user_input.lower() == 'q':
        break
    else:
        if is_palindrome(user_input):
            print("It's a palindrome!")
        else:
            print("It's not a palindrome.")