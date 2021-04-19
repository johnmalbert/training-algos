#hackerrank's mod DivMod Algorithm in Python
# input: integer a, b
# output: integer a/b, a modulus b, divmod(a,b)
def div_mod(a,b):
    print(int(a/b))
    print(a%b)
    print(divmod(a,b))

num = int(input())
den = int(input())    
div_mod(num,den)
