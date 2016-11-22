# CryptoCracker
**22 NOV 2016 (Originally: 29 OCT 2016):** The intent of this application is for me to learn how 
to create an application that can break hand ciphers (monoalphabetic, polyalphabetic, transposition) 
and simple/historical machine ciphers (Enigma).

Beyond traditional analysis of letter frequency, di/trigraphs, and indices of coincidence, my
main goal for this project is to develop a means of efficiently working
through all of the possibilities of two ciphers I have encountered on a
certain website. They both display simple substitution frequency distribution 
characteristics, but when applied, it yields gibberish in English, German, 
and Spanish.
 
My goal is to develop an algorithm that can discover a certain pattern.
The hypotheses is that this cipher is, indeed, a simple substitution,
yet the deciphered plain text is a second cipher text. Possibly every
third letter, a second substitution, etc. The idea is that the algorithm
can analyze the cipher and find a likely solution on its own.

I'm guessing that this will wind up being an excercise to find the most efficient
search algorithms for large numbers of strings, the Oxford Dictionary, for example.
The cryptanalysis can probably be accomplished fairly quickly, and possible solutions
may also be discovered quickly, but I believe everything will hinge on the ability to 
find those patterns in a given dictionary in an efficient manner.
