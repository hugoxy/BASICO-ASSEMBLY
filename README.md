## → BÁSICO ASSEMBLY MIPS (MARS) ## 
```
Tutorial Básico de Assembly Mips (Plataforma Mars)

Programas básicos em Assembly Mips onde possibilita o cálculo da média ponderada de acordo com a nota do Enem!
Ideal para calcular sua nota média em universidade onde se tem peso maior em determinada matéria!
```
## → YOUTUBE VIDEO TUTORIAL ##

https://www.youtube.com/watch?v=mQeyDkqXffU

## → ASSEMBLY CODE ##
```
  .data #Dados
  mensagem:  .asciiz "Calcule sua media do ENEM em universidades que tem um maior peso em determinada materia!\n" #declara variavel "string" ja com texto.
  mensagem1: .asciiz "Qual sua nota em Linguagens, Códigos e suas Tecnologias:\n" #declara variavel "string" ja com texto.
  mensagem2: .asciiz "Qual sua nota em Matemática e suas Tecnologias:\n" #declara variavel "string" ja com texto.
  mensagem3: .asciiz "Qual sua nota em Ciências da Natureza e suas Tecnologias:\n" #declara variavel "string" ja com texto.
  mensagem4: .asciiz "Qual sua nota em Ciências Humanas e suas Tecnologias::\n" #declara variavel "string" ja com texto.
  mensagem5: .asciiz "Qual sua nota na redação:\n" #declara variavel "string" ja com texto.
  mensagem6: .asciiz "A sua  nota com base na média ponderada é:\n" #declara variavel "string" ja com texto.
  mensagem7: .asciiz "Qual o peso desta materia:\n" #declara variavel "string" ja com texto.
  .text #Instruções
main: 
  li $v0, 4
  la $a0, mensagem # imprime mensagem do proposito do programa!
  syscall
  li $v0, 4
  la $a0, mensagem1 # imprime mensagem de linguagues
  syscall
  li $v0, 5  #lê inteiro
  syscall
  move $t0,$v0 #t0 = notapt ## Pode-se utilizar também o add e o addi; $zero,0
  li $v0, 4
  la $a0, mensagem7 # imprime mensagem de "Qual o Peso"!
  syscall
  li $v0, 5  #lê inteiro
  syscall
  move $t1,$v0 # t1 = peso PT
  li $v0, 4
  la $a0, mensagem2 # imprime mensagem de matetmatica
  syscall
  li $v0, 5  #lê inteiro
  syscall
  move $t2,$v0 # t2 = nota mat
  li $v0, 4
  la $a0, mensagem7 # imprime mensagem de "Qual o Peso"!
  syscall
  li $v0, 5  #lê inteiro
  syscall
  move $t3,$v0 #t3 = peso mat
  li $v0, 4
  la $a0, mensagem3 # imprime mensagem de ciencias natureza
  syscall
  li $v0, 5  #lê inteiro
  syscall
  move $t4,$v0 #t4 = nota ci natureza!
  li $v0, 4
  la $a0, mensagem7 # imprime mensagem de "Qual o Peso"!
  syscall
  li $v0, 5  #lê inteiro
  syscall
  move $t5,$v0 #t5 = peso ci natureza
  li $v0, 4
  la $a0, mensagem4 # imprime mensagem ciencias humanas
  syscall
  li $v0, 5  #lê inteiro
  syscall
  move $t6,$v0 #t6= nota ci humanas 
  li $v0, 4
  la $a0, mensagem7 # imprime mensagem de "Qual o Peso"!
  syscall 
  li $v0, 5  #lê inteiro
  syscall 
  move $t7,$v0 #t7= peso ci humanas
  li $v0, 4
  la $a0, mensagem5 # imprime mensagem redação
  syscall
  li $v0, 5  #lê inteiro
  syscall  
  move $t8,$v0 #t8=nota redação!
  li $v0, 4
  la $a0, mensagem7 # imprime mensagem de "Qual o Peso"!
  syscall
  li $v0, 5  #lê inteiro
  syscall
  move $t9,$v0 #t9= peso redação
  
  mul $s0,$t0,$t1 # x*p  # CALCULOS MATEMATICOS #
  mul $s1,$t2,$t3 # x*p
  mul $s2,$t4,$t5 # x*p
  mul $s3,$t6,$t7 # x*p
  mul $s4,$t8,$t9 # x*p
  add $s0,$s0,$s1 
  add $s1,$s2,$s3
  add $s2,$s0,$s1
  add $s0,$s2,$s4
  add $s1,$t1,$t3
  add $s2,$t5,$t7
  add $s1,$s1,$s2
  add $s1,$s1,$t9
  div $s2,$s0,$s1
  li $v0, 4
  la $a0, mensagem6 # imprime mensagem
  syscall
  addi $a0,$s2,0
  li $v0, 1  #print inteiro
  syscall
  li $v0, 10  #finaliza
  syscall
  ```
  
  
## → MESMO CODIGO EM C# PARA COMPARAÇÕES##
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaMediaPonderada
{
    class Program
    {
        static void Main(string[] args)
        {
            int notapt, notamat, notacinatu,notacihuma,notared,pesopt, pesomat, pesocinatu, pesocihuma,pesored, mediaponderada, mediaponderadapt1, mediaponderadapt2;
            Console.WriteLine("Calcule sua media do ENEM em universidades que tem um maior peso em determinada materia!\n");

            Console.WriteLine("Qual sua nota em Linguagens, Códigos e suas Tecnologias:");
            notapt = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o peso desta matéria?:");
            pesopt = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua nota em Matemática e suas Tecnologias:");
            notamat = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o peso desta matéria?:");
            pesomat = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua nota em Ciências da Natureza e suas Tecnologias:");
            notacinatu = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o peso desta matéria?:");
            pesocinatu = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua nota em Ciências Humanas e suas Tecnologias:");
            notacihuma = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o peso desta matéria?:");
            pesocihuma = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua nota na redação:");
            notared = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o peso desta matéria?:");
            pesored = int.Parse(Console.ReadLine());

            mediaponderadapt1=(notapt*pesopt)+(notamat*pesomat)+(notacinatu*pesocinatu)+(notacihuma*pesocihuma)+(notared*pesored);
            mediaponderadapt2 = pesomat + pesopt + pesocinatu + pesocihuma + pesored;
            mediaponderada = mediaponderadapt1/mediaponderadapt2;
            Console.WriteLine("A sua média ponderada é:" + mediaponderada);
            Console.ReadKey();
        }
    }
}
```

## → DOWNLOAD DO COMPILADOR MIPS MARS##
```
 http://courses.missouristate.edu/KenVollmar/mars/download.htm
```
