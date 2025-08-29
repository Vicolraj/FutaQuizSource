namespace FutaQuiz.Questions
{
    public class MTS
    {
        public static int BonusTime = 10;
        public static List<QuestionPreset>? Questions_ =
        [
            //MTS101 101 101 101 101 101 101
            //MTS101 101 101 101 101 101 101
            //MTS101 101 101 101 101 101 101
            //MTS101 101 101 101 101 101 101
            //MTS101 101 101 101 101 101 101
            //MTS101 101 101 101 101 101 101
#region "MTS101"
            new("MTS101")
            {
                QuestionsList =
                [     new()
                    {
                        StrQuestion = "____________ is used to prove the validity of proposition of the set of non-negative integers.",
                        Options = ["Real number system", "Real line", "Associativity", "The principle of mathematical induction"],
                        Answer = "The principle of mathematical induction",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following statements is false for all positive integers using the principle of mathematical induction?",
                        Options = ["2n > n", "52n + 3n + 1 is a multiple of 9", "5n − 1 is a multiple of 4", "72n+1 + 1 is a multiple of 3"],
                        Answer = "72n+1 + 1 is a multiple of 3",
                    },

                    new()
                    {
                        StrQuestion = "A student of the Department of Mathematical Sciences, Federal University of Technology, Akure was asked to show that 5n − 1 is divisible by 4 for all positive integers k using the principle of mathematical induction. Which of the following mathematical statements is correct for all positive integers M?",
                        Options = ["f(1) = 8", "f(M) = 4(5M + 1)", "f(k + 1) = 4(5M + 1)", "f(k) = 4(5M + 1)"],
                        Answer = "f(k + 1) = 4(5M + 1)",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is not one of the properties of real numbers?",
                        Options = ["Existence of the multiplicative inverse", "Closure", "It satisfies the principle of mathematical induction", "Existence of the zero of the set"],
                        Answer = "It satisfies the principle of mathematical induction",
                    },

                    new()
                    {
                        StrQuestion = "Let a, b, c and d be real numbers. Which of the following statements is false?",
                        Options = ["If a > b, then a + c < b + c", "If a > b and c > 0, then ac > bc", "If a > b and c < 0, then ac < bc", "If a > b and c > d, then a + c > b + d"],
                        Answer = "If a > b, then a + c < b + c",
                    },
                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "A 100L student of the department of Biochemistry, Federal University of Technology, Akure, Samuel Victory, was asked to use the principle of mathematical induction to prove that ∑ xi = (1 - x^(n+1)) / (1 - x) for what values of x can she prove this?",
                        Options = ["For all real numbers x", "For all real numbers x satisfying x ≠ 1", "For all real numbers x satisfying x = 1", "For all positive integers n"],
                        Answer = "For all real numbers x satisfying x ≠ 1",
                    },

                    new()
                    {
                        StrQuestion = "Mr. Dansu’s project student was asked to prove that f(n) = n^4 + 4n^2 + 11 is divisible by 16 for all odd positive integers. What are the possible values of n?",
                        Options = ["1, 2, 3, …, k, k+1 where k is a positive integer", "1, 2, 3, …, k, k+1, …, ∞ where k is a positive integer", "1, 3, …, 2k-1, 2k+1, … where k is a positive integer", "None of the above"],
                        Answer = "1, 3, …, 2k-1, 2k+1, … where k is a positive integer",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is the sequential arrangement of the application of the principle of mathematical induction?",
                        Options = ["ii, i and iii", "i, ii and iii", "i, iii and ii", "iii, ii and i"],
                        Answer = "i, iii and ii",
                    },

                    new()
                    {
                        StrQuestion = "Given that 1/(1∙2) + 1/(2∙3) + 1/(3∙4) + ⋯ + 1/(n(n+1)) = n/(n+1). If k is a positive integer, then by the use of the principle of mathematical induction:",
                        Options = ["f(k + 1) = (k+3)/((k+1)(k+2))", "f(k + 1) = (k+3)/((k+1)(k+3))", "f(k + 1) = 1/((k+1)(k+2))", "f(k + 1) = k/(k+1)"],
                        Answer = "f(k + 1) = (k+3)/((k+1)(k+2))",
                    },

                    new()
                    {
                        StrQuestion = "In proving that f(n) = 72n+1 + 1 is a multiple of 8, Mr. Olodo assumed that the proposition is valid when n=k where k is a positive integer. Which of the following statements is correct?",
                        Options = ["f(K + 1) = 344", "f(K + 1) = 8(49M − 6) where M is a positive integer", "f(K + 1) = 8M − 1 where M is a positive integer", "f(K + 1) = 8(49M + 6) where M is a positive integer"],
                        Answer = "f(K + 1) = 8(49M − 6) where M is a positive integer",
                    },
                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Which of the following laws of algebra of addition and multiplication of natural numbers is incorrect for all x, y, z ∈N?",
                        Options = ["Closure: (i) x + y ∈ N (ii) x. y ∈ N", "Commutative: (i) x + y = y+ x (ii) x . y = y. x", "Associative: (i) x + (y + z) = (x + y) + z (ii) x . (y + z) = (x . y) . z", "Distributive: (i) x.(y + z) = x . y + x . z (ii) (y + z) . x = y . x + z . x"],
                        Answer = "Associative: (i) x + (y + z) = (x + y) + z (ii) x . (y + z) = (x . y) . z",
                    },

                    new()
                    {
                        StrQuestion = "Given that for all positive integer values of n, 52n + 3n − 1 is an integer multiple of 9. If k is a positive integer, then by the principle of mathematical induction",
                        Options = ["f(k + 1) = 9(25M + 8k + 3) where M is a positive integer", "f(k + 1) = 9(25M − 8k + 3) where M is a positive integer", "f(k + 1) = 52(k+1) + 3k + 2 where M is a positive integer", "f(k) = 52(k+1) + 3k + 2 where M is a positive integer"],
                        Answer = "f(k + 1) = 9(25M − 8k + 3) where M is a positive integer",
                    },

                    new()
                    {
                        StrQuestion = "Given the set A= {a,b,c,d}; which of the following is not an element of the power set of A?",
                        Options = ["{a,b}", "{Ø}", "A", "{a,b,c}"],
                        Answer = "{Ø}",
                    },

                    new()
                    {
                        StrQuestion = "How many subsets will a set containing 5 elements have?",
                        Options = ["32", "25", "36", "64"],
                        Answer = "32",
                    },

                    new()
                    {
                        StrQuestion = "If µ = {e,f,g,h,p,q,r,s} be the universal set, M= {e,h,q,s} and N= {h,p,r}. Find Mc ∪ Nc.",
                        Options = ["{f,p,r}", "{e,f,q,s}", "{e,f,g,p,q,r,s}", "{e,g,p,q,r,s}"],
                        Answer = "{e,f,g,p,q,r,s}",
                    },
                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Which of the following is equivalent to [Pc∪ (Q∩Qc)]",
                        Options = ["P", "Pc", "Q", "Qc"],
                        Answer = "Pc",
                    },

                    new()
                    {
                        StrQuestion = "Given that the sets A and B are partitioned sets of E; then A ∩ (E∩B)c is",
                        Options = ["A", "Ø", "B", "E"],
                        Answer = "A",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following sets is equivalent to (P∪Q)∩(P∩Qc)",
                        Options = ["P∪Q", "PUQc", "P∩Qc", "Ø"],
                        Answer = "P∩Qc",
                    },

                    new()
                    {
                        StrQuestion = "P and Q are subsets of the universal set U defined as U = {x: x^3 − x^2 − x + 1 = 0}. P = {x: x is an integer} and Q = {x: x odd}, find P∩Q.",
                        Options = ["{-1,1,1}", "{-1,1}", "{1,1,-1}", "{-1,-1}"],
                        Answer = "{-1,1}",
                    },

                    new()
                    {
                        StrQuestion = "P and Q are subsets of the universal set µ defined as µ = {x: x is an integer and 1<x<15}. P = {x: x is odd} and Q={x: x is prime}. Find the cardinal number of the intersection of the complements of P and Q.",
                        Options = ["3", "4", "5", "6", "9"],
                        Answer = "6",
                    },
                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Four members of a school first eleven cricket team are also members of the first fourteen Rugby team. How many boys play in only one of the two teams?",
                        Options = ["25", "21", "17", "29"],
                        Answer = "17",
                    },

                    new()
                    {
                        StrQuestion = "If S = {x: x^2= 9, x< 2} then S is equal to",
                        Options = ["{-3}", "{3}", "Ø", "{-3,3}"],
                        Answer = "{-3}",
                    },

                    new()
                    {
                        StrQuestion = "A School of 38 teachers has 15 married women. If 6 of the teachers are couples, how many of the teachers are neither married nor have their spouses not in the school?",
                        Options = ["17", "23", "20", "21"],
                        Answer = "20",
                    },

                                                    new()
                    {
                        StrQuestion = "If P = {1,2,3,4,5,6,7,8}, Q = {1,4,9}, R= {2,4,8}. Find (P∩Q)∪R.",
                        Options = ["{1,2,4,8}", "{1,2,4,8,9}", "{1,2,4,7,8}", "{1,2,3,4,5,6,7,8}"],
                        Answer = "{1,2,4,8,9}",
                    },

                    new()
                    {
                        StrQuestion = "In a class of 40 students, 24 play football, 18 play volleyball and 6 do not play any game. How many Students play both Football and Volleyball?",
                        Options = ["2", "7", "8", "9"],
                        Answer = "8",
                    },
                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "If E = {1,2,3,4} and A = {1,3,5}, the symmetric difference of E and A written A Δ E is",
                        Options = ["{1,2}", "{2,4,5}", "{1,2,3,4,5}", "{1,3}"],
                        Answer = "{2,4,5}"
                    },

                    new()
                    {
                        StrQuestion = "If the universal set U = {x: x is a natural number and 1≤ x≤ 9 }, P = {x:1≤x<4} and Q = {2,4,6,8}. Find (P U Q)c",
                        Options = ["{1,2,3,4,5,6,7,8,9}", "{1,2,3,4,6,8}", "{1,5,6,7}", "{5,7,9}"],
                        Answer = "{5,7,9}"
                    },

                    new()
                    {
                        StrQuestion = "In a science class of 41 students, each student offers at least one of Mathematics and Physics. If 22 Students offer Physics and 28 Students offer Mathematics, how many Students offer Physics only",
                        Options = ["19", "9", "13", "14"],
                        Answer = "13"
                    },

                    new()
                    {
                        StrQuestion = "If U = {0, 2,3,6,7,8,9,10} is the universal set, E = {0,6,8,10} and F = {x: x^4=14}. Find (E ∪ F)c",
                        Options = ["{3,7,9}", "{2,3,7,9}", "{3,7,9}", "Ø"],
                        Answer = "{3,7,9}"
                    },

                    new()
                    {
                        StrQuestion = "If X = {all prime factors of 44} and Y = {all prime factors of 60}. The elements of X ∪ Y and X ∩ Y respectively are:",
                        Options = ["{2,4,3,5,11} and {4}", "{4,3,5,1} and {3,4}", "{2,5,11} and {2}", "{2,3,5,11} and {2}"],
                        Answer = "{2,3,5,11} and {2}"
                    },
                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Simplify (A ∪ B)c ∩ (A ∩ Bc)",
                        Options = ["(Ac ∪ B)", "A ∪ Bc", "(A ∪ B)c", "ϕ"],
                        Answer = "ϕ"
                    },

                    new()
                    {
                        StrQuestion = "Simplify (A ∪ B)c ∩ Ac",
                        Options = ["(A ∪ B)", "A ∩ Bc", "Ac ∩ B", "(Ac ∩ Bc)"],
                        Answer = "(Ac ∩ Bc)"
                    },

                    new()
                    {
                        StrQuestion = "In a village all the people speak Hausa or English or both, if 56% speak Hausa and 63% speak English, what percentage speak both languages",
                        Options = ["19%", "119%", "62%", "38%"],
                        Answer = "19%"
                    },

                    new()
                    {
                        StrQuestion = "………………… is a set that contains another set.",
                        Options = ["Power set", "Super set", "Subset", "Proper Set"],
                        Answer = "Super set"
                    },

                    new()
                    {
                        StrQuestion = "In a youth club with 94 members, 60 like modern music and 50 like traditional music. The number of members who like both traditional and modern music is thrice those who do not like any type of music. How many members like only one type of music?",
                        Options = ["8", "24", "62", "86"],
                        Answer = "62"
                    },
                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "The symmetric difference of A and B expressed A △ B is equal to …………………",
                        Options = ["(A−B) ∩ (B−A)", "(A−B) ∪ (B−A)", "(A ∩ B) ∪ (B ∩ A)", "(A U B) ∩ (B U A)"],
                        Answer = "(A−B) ∪ (B−A)"
                    },

                    new()
                    {
                        StrQuestion = "ξ = {e,f,g,h,p,q,r,s}, M = {e,h,q,s} and N = {h,p,r}. Find Mc ∪ Nc",
                        Options = ["{f,p,r}", "{e,f,q,s}", "{e,f,g,p,q,r,s}", "{e,g,p,q,r,s}"],
                        Answer = "{e,f,g,p,q,r,s}"
                    },

                    new()
                    {
                        StrQuestion = "How many subsets will a set containing 6 elements have?",
                        Options = ["25", "32", "36", "64"],
                        Answer = "64"
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is equivalent to {Pc ∩ (Q ∪ Qc)}",
                        Options = ["P", "Pc", "Q", "ϕ"],
                        Answer = "Pc"
                    },

                    new()
                    {
                        StrQuestion = "Which of the following options below is true",
                        Options = ["A ∪ Ac = A", "A ∩ Ac = A", "(Ac)c = U", "nP(A) = 2n(A)"],
                        Answer = "nP(A) = 2n(A)"
                    },
                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Out of 25 teachers, 16 are married and 15 are women. If 6 of the men are married, how many of the women are not married?",
                        Options = ["6", "10", "5", "9"],
                        Answer = "5"
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is not a true property of a Cartesian product?",
                        Options = ["(A ∩ B) x (C ∩ D) = (A x C) ∩ (B x D)", "(A ∪ B) x (C ∪ D) = (A x C) ∪ (B x D)", "(A ∪ B) x C = (A x C) ∪ (B x C)", "A x Ø = Ø x A = A"],
                        Answer = "A x Ø = Ø x A = A"
                    },

                    new()
                    {
                        StrQuestion = "If (A∩Bc) ∪ (Ac∩B) = A Δ B, what does the symbol “Δ” signify?",
                        Options = ["“difference”", "“asymmetric difference”", "“symmetric difference”", "“union”"],
                        Answer = "“symmetric difference”"
                    },

                    new()
                    {
                        StrQuestion = "Let U= {1,2,3,4,5,6} be the universal, A={1,2,3} and B={4,5,6}. Find Ac ∪ (B∪Bc).",
                        Options = ["Ø", "{1,2,3}", "{4,5,6}", "U"],
                        Answer = "U"
                    },

                    new()
                    {
                        StrQuestion = "C = {1, 2, 3, 4,...}. What is the name of the set C?",
                        Options = ["Finite set", "Closed set", "Universal set", "Infinite set"],
                        Answer = "Infinite set"
                    },

                    new()
                    {
                        StrQuestion = "What does the set {x: x ∉ A and x ∈ B} define?",
                        Options = ["set containing elements in A and not in B", "set containing elements not in A but in B", "set containing elements both in A and B", "set containing elements both in A and B"],
                        Answer = "set containing elements not in A but in B"
                    },
                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "When a set C= { } it means that C is______",
                        Options = ["a universal set", "C is finite set", "C is an empty set", "is a universal set"],
                        Answer = "C is an empty set"
                    },

                    new()
                    {
                        StrQuestion = "A⊆B and B⊆C implies A ⊆ C is the_______________",
                        Options = ["Complementary law", "Transitivity Law", "Inverse law", "Commutativity"],
                        Answer = "Transitivity Law"
                    },

                                new()
                    {
                        StrQuestion = "Evaluate sin2θ cos2θ−1.",
                        Options = ["−1", "1", "2", "−2"],
                        Answer = "−1"
                    },
                    new()
                    {
                        StrQuestion = "Simplify sin2x tan x.",
                        Options = ["sin x", "cos x", "sin x cos x", "sin2 x cos2 x"],
                        Answer = "sin x cos x"
                    },
                    new()
                    {
                        StrQuestion = "If tan(1/2 x) = b, express tan x in terms of b.",
                        Options = ["2b", "1 − b2", "1−b2/2b", "2b/(1−b2)"],
                        Answer = "2b/(1−b2)"
                    },
                    new()
                    {
                        StrQuestion = "If tan(1/2 x) = f, what is sin x in terms of f?",
                        Options = ["2f/(1+f2)", "2f/(1+f)", "2f2/(1+f)", "2f2/(1+f2)"],
                        Answer = "2f/(1+f2)"
                    },
                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "If tan(1/2 x) = k, what is cos x in terms of k?",
                        Options = ["2k2/(1+k2)", "1−2k2/(1+k2)", "1−k2/(1+k2)", "1+k2/(1−k2)"],
                        Answer = "1−k2/(1+k2)"
                    },
                    new()
                    {
                        StrQuestion = "What is the result of 1 + tan2θ?",
                        Options = ["sin2 θ", "sec2θ", "cos2θ", "tan2θ"],
                        Answer = "sec2θ"
                    },
                    new()
                    {
                        StrQuestion = "Evaluate 1 + cot2θ.",
                        Options = ["sin2 θ", "cosec2θ", "cos2θ", "tan2θ"],
                        Answer = "cosec2θ"
                    },
                    new()
                    {
                        StrQuestion = "Simplify sin2p + (1 + cos2p)2.",
                        Options = ["2(1 + cos p)", "2 cos p", "1 + cos p", "cos p − 1"],
                        Answer = "2(1 + cos p)"
                    },
                    new()
                    {
                        StrQuestion = "Evaluate 1+sin ∅ 1+cos ∅ × 1+sec ∅ 1+cosec ∅.",
                        Options = ["sin ∅", "cos ∅", "tan ∅", "cot ∅"],
                        Answer = "tan ∅"
                    },
                    new()
                    {
                        StrQuestion = "Expand tan(450 + A).",
                        Options = ["(1+tan A)/(1+tan A)", "(1−tan A)/(1−tan A)", "(1+tan A)/tan A", "(1+tan A)/(1−tan A)"],
                        Answer = "(1+tan A)/(1−tan A)"
                    },
                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Evaluate tan(900 + A).",
                        Options = ["0", "∞", "−1", "1"],
                        Answer = "∞"
                    },
                    new()
                    {
                        StrQuestion = "If sin 450 = cos 450 = 1/√2 ; sin 300 = 1/2; cos 300 = √3/2, evaluate sin 750.",
                        Options = ["√2+√6/4", "√2−√6/4", "√6−√2/4", "√2+√3/4"],
                        Answer = "√2+√6/4"
                    },
                    new()
                    {
                        StrQuestion = "If sin 450 = cos 450 = 1/√2 ; sin 300 = 1/2; cos 300 = √3/2, evaluate cos 750.",
                        Options = ["√6+√2/4", "√2+√3/4", "√6−√2/4", "√2−√6/4"],
                        Answer = "√6−√2/4"
                    },
                    new()
                    {
                        StrQuestion = "Find cos 1050, if sin 450 = cos 450 = 1/√2, sin 600 = √23; cos 600 = 1/2",
                        Options = ["√2+√6/4", "√2−√6/4", "√2−√6/5", "√2−√3/4"],
                        Answer = "√2−√6/4"
                    },
                    new()
                    {
                        StrQuestion = "Which of these evaluates to 1?",
                        Options = ["sec2x − tan2x", "sec2x + tan2x", "tan2x − sec2x", "tan x − sec2x"],
                        Answer = "sec2x − tan2x"
                    },
                    new()
                    {
                        StrQuestion = "Which of these evaluates to 1?",
                        Options = ["cot y − cosec y", "cot2y − cosec2y", "cosec y − cot y", "cosec2y − cot2y"],
                        Answer = "cosec2y − cot2y"
                    },
                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "sin 810 is the same as …….",
                        Options = ["cos 90", "sin 90", "tan 90", "sec 90"],
                        Answer = "cos 90"
                    },
                    new()
                    {
                        StrQuestion = "What is the equivalence of tan(A + B)?",
                        Options = ["cos(A+B)/sin(A+B)", "1/tan(A+B)", "(tan A+tan B)/(1−tan A tan B)", "(tan A−tan B)/(1+tan A tan B)"],
                        Answer = "(tan A+tan B)/(1−tan A tan B)"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is the same as tan(A − B)?",
                        Options = ["cos(A+B)/sin(A+B)", "1/tan(A+B)", "(tan A+tan B)/(1−tan A tan B)", "(tan A−tan B)/(1+tan A tan B)"],
                        Answer = "(tan A−tan B)/(1+tan A tan B)"
                    },
                    new()
                    {
                        StrQuestion = "What is the equivalence of tan 900?",
                        Options = ["0", "1", "−1", "∞"],
                        Answer = "∞"
                    },
                    new()
                    {
                        StrQuestion = "If cos δ = a/b, find 1 + tan2δ.",
                        Options = ["b/a", "b/a2", "a2/b2", "a2/b"],
                        Answer = "a2/b2"
                    },
                    new()
                    {
                        StrQuestion = "Find the value of sin2x + cos2x.",
                        Options = ["0", "1", "2", "−1"],
                        Answer = "1"
                    },
                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Evaluate sec2p − 1.",
                        Options = ["tan p", "tan p sec p", "tan2p", "tan3p"],
                        Answer = "tan2p"
                    },
                    new()
                    {
                        StrQuestion = "Evaluate tan2q − sec2q.",
                        Options = ["1", "−1", "2", "−2"],
                        Answer = "−1"
                    },
                    new()
                    {
                        StrQuestion = "What is the result of sec2x − tan2x?",
                        Options = ["1", "−1", "2", "−2"],
                        Answer = "1"
                    },
                    new()
                    {
                        StrQuestion = "Which of these evaluates to −1?",
                        Options = ["cot2r + cosec2r", "cot r", "cot2r − cosec2r", "cot r − cosec r"],
                        Answer = "cot2r − cosec2r"
                    },
                    new()
                    {
                        StrQuestion = "Which of these is equivalent to sin 2w?",
                        Options = ["2 sin wcos w", "2sin2w", "2cos2w", "sin wcos w"],
                        Answer = "2 sin wcos w"
                    },
                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Expand cos(x − y).",
                        Options = ["cos x cos y − sin x sin y", "cos x cos y + sin x sin y", "sin x sin y − cos x cos y", "sin x sin y + cos x cos y"],
                        Answer = "cos x cos y − sin x sin y"
                    },
                    new()
                    {
                        StrQuestion = "Express sin 600 in surd form.",
                        Options = ["1/2", "√3/2", "1/√2", "0"],
                        Answer = "√3/2"
                    },
                    new()
                    {
                        StrQuestion = "Express sin 450 in surd form.",
                        Options = ["1/2", "√3/2", "1/√2", "0"],
                        Answer = "1/√2"
                    },
                    new()
                    {
                        StrQuestion = "Which of these is equal to sin ϑ?",
                        Options = ["1 − cos ϑ", "cos(900 − ϑ)", "sin(900 − ϑ)", "cos ϑ − 1"],
                        Answer = "cos(900 − ϑ)"
                    },
                    new()
                    {
                        StrQuestion = "Which of these is equivalent to cos 130?",
                        Options = ["sin 770", "cos 770", "sin 870", "cos 870"],
                        Answer = "sin 770"
                    },
                    new()
                    {
                        StrQuestion = "Which of these is equivalent to cos β?",
                        Options = ["cos(900 − β)", "sin(900 − β)", "sec(900 − β)", "cosec(900 − β)"],
                        Answer = "sin(900 − β)"
                    },
                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Expand sin v.",
                        Options = ["sin(1/2v)cos(1/2v)", "sin2(1/2v)", "cos2(1/2v)", "2sin(1/2v)cos(1/2v)"],
                        Answer = "2sin(1/2v)cos(1/2v)"
                    },
                    new()
                    {
                        StrQuestion = "Expand cos a.",
                        Options = ["cos2 a/2 + 1", "2cos2 a/2 − 1", "2cos2 a/2 + 1", "2−cos2 a/2"],
                        Answer = "2cos2 a/2 − 1"
                    },
                    new()
                    {
                        StrQuestion = "What is the equivalence of sin(p + q)?",
                        Options = ["sin p sin q + cos p cos q", "sin p sin q − cos p cos q", "sin p cos q − cos p sin q", "sin p cos q + cos p sin q"],
                        Answer = "sin p cos q + cos p sin q"
                    },
                    new()
                    {
                        StrQuestion = "What is the equivalence of sin(p − q)?",
                        Options = ["sin p sin q + cos p cos q", "sin p sin q − cos p cos q", "sin p cos q − cos p sin q", "sin p cos q + cos p sin q"],
                        Answer = "sin p cos q − cos p sin q"
                    },
                    new()
                    {
                        StrQuestion = "Expand cos(x + y).",
                        Options = ["cos x cos y − sin x sin y", "cos x cos y + sin x sin y", "sin x sin y − cos x cos y", "sin x sin y + cos x cos y"],
                        Answer = "cos x cos y − sin x sin y"
                    },

                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Which of these is equivalent to cos 2z?",
                        Options = ["1 − cos2z", "1 + cos z", "2cos2z − 1", "1 + 2cos2z"],
                        Answer = "2cos2z − 1"
                    },
                    new()
                    {
                        StrQuestion = "Which of these is equivalent to tan 2t?",
                        Options = ["(1−tan2t)/t", "2 tan t/(1−tan2t)", "(1−tan2t)/2 tan t", "tan t+1/2 tan t"],
                        Answer = "2 tan t/(1−tan2t)"
                    },

                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Evaluate sin2θ / cos2θ − 1.",
                        Options = ["−1", "1", "2", "−2"],
                        Answer = "−1"
                    },

                    new()
                    {
                        StrQuestion = "Simplify sin2x / tan x.",
                        Options = ["sin x", "cos x", "sin x cos x", "sin2 x cos2 x"],
                        Answer = "sin x cos x"
                    },

                    new()
                    {
                        StrQuestion = "If tan(1/2) x = b, express tan x in terms of b.",
                        Options = ["2b", "1 − b²", "(1 − b²) / 2b", "2b / (1 − b²)"],
                        Answer = "2b / (1 − b²)"
                    },

                    new()
                    {
                        StrQuestion = "If tan(1/2) x = f, what is sin x in terms of f?",
                        Options = ["2f / (1 + f²)", "2f / (1 + f)", "2f² / (1 + f)", "2f² / (1 + f²)"],
                        Answer = "2f / (1 + f²)"
                    },

                    new()
                    {
                        StrQuestion = "If tan(1/2) x = k, what is cos x in terms of k?",
                        Options = ["2k² / (1 + k²)", "(1 − 2k²) / (1 + k²)", "(1 − k²) / (1 + k²)", "(1 + k²) / (1 − k²)"],
                        Answer = "(1 − k²) / (1 + k²)"
                    },



                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What is the result of 1 + tan²θ?",
                        Options = ["sin² θ", "sec²θ", "cos²θ", "tan²θ"],
                        Answer = "sec²θ"
                    },

                    new()
                    {
                        StrQuestion = "Evaluate 1 + cot²θ.",
                        Options = ["sin² θ", "cosec²θ", "cos²θ", "tan²θ"],
                        Answer = "cosec²θ"
                    },
                    new()
                    {
                        StrQuestion = "Simplify sin²p + (1 + cos²p)².",
                        Options = ["2(1 + cos p)", "2 cos p", "1 + cos p", "cos p − 1"],
                        Answer = "2(1 + cos p)"
                    },

                    new()
                    {
                        StrQuestion = "Evaluate 1 + sin ∅ / 1 + cos ∅ × 1 + sec ∅ / 1 + cosec ∅.",
                        Options = ["sin ∅", "cos ∅", "tan ∅", "cot ∅"],
                        Answer = "tan ∅"
                    },

                    new()
                    {
                        StrQuestion = "Expand tan(45° + A).",
                        Options = ["(1 + tan A) / (1 + tan A)", "(1 − tan A) / (1 − tan A)", "(1 + tan A) / tan A", "(1 + tan A) / (1 − tan A)"],
                        Answer = "(1 + tan A) / (1 − tan A)"
                    },

                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "The first term of an arithmetic series is ___, the common difference is ___, and the sum of all terms is ___. Find the number of terms and the last term.",
                        Options = ["79, 20", "20, 79", "-20.5, 80", "80, -20.5"],
                        Answer = "80, -20.5"
                    },

                    new()
                    {
                        StrQuestion = "Find the sum to which the series converges.",
                        Options = ["A", "B", "C", "D"],
                        Answer = "C"
                    },

                    new()
                    {
                        StrQuestion = "What is the ninth term of the geometric sequence if the third term and the seventh term are ___ and ___?",
                        Options = ["3", "B", "C", "D"],
                        Answer = "B"
                    },

                    new()
                    {
                        StrQuestion = "What is the second term of the series, if the three numbers in geometric sequence whose sum is 13 and whose product is ___?",
                        Options = ["4", "3", "5", "6"],
                        Answer = "4"
                    },

                    new()
                    {
                        StrQuestion = "Evaluate the tenth term of the series.",
                        Options = ["50499", "59490", "59049", "59940"],
                        Answer = "59049"
                    },
                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Find the three numbers in arithmetic progression whose sum is 3 and whose product is ___.",
                        Options = ["A", "B", "C", "D"],
                        Answer = "C"
                    },

                    new()
                    {
                        StrQuestion = "If ___ and ___, find ___ and ___.",
                        Options = ["A", "B", "C", "D"],
                        Answer = "B"
                    },

                    new()
                    {
                        StrQuestion = "To what sum does the following series converge?",
                        Options = ["A", "B", "C", "D"],
                        Answer = "C"
                    },

                    new()
                    {
                        StrQuestion = "The first term and the last term of a geometric series are 3 and 768, if the sum of the terms is 1533. Find the common ratio.",
                        Options = ["3", "B", "2", "C"],
                        Answer = "2"
                    },

                    new()
                    {
                        StrQuestion = "Find the first term and common ratio of the geometric series if the third term and the seventh term are 81 and 16 respectively.",
                        Options = ["A", "B", "C", "D"],
                        Answer = "A"
                    },
                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "The sum of the first twenty terms of an arithmetic progression is 45, and the sum of the first forty terms is 290. Find the first term and the common difference.",
                        Options = ["A", "B", "C", "D"],
                        Answer = "C"
                    },

                    new()
                    {
                        StrQuestion = "Find the formula for ___.",
                        Options = ["n!", "B", "C", "D"],
                        Answer = "B"
                    },

                    new()
                    {
                        StrQuestion = "What limit does the sequence converge into?",
                        Options = ["0", "B", "C", "1"],
                        Answer = "1"
                    },

                    new()
                    {
                        StrQuestion = "Find the ___ for the arithmetic sequence.",
                        Options = ["A", "B", "C", "D"],
                        Answer = "C"
                    },

                    new()
                    {
                        StrQuestion = "Find the sum of all the odd numbers between 1 and 99.",
                        Options = ["25000", "2500", "250", "250000"],
                        Answer = "2500"
                    },
                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "A model railway manufacturer makes pieces of track of lengths 8cm, 10cm, 12cm etc up to and including 38cm. An enthusiast buys 5 pieces of each length. What is the total length of track that can be made?",
                        Options = ["345", "300", "380", "400"],
                        Answer = "345"
                    },

                    new()
                    {
                        StrQuestion = "The general formula for the reciprocal of geometric sequences is ___.",
                        Options = ["A", "B", "C", "D"],
                        Answer = "A"
                    },

                    new()
                    {
                        StrQuestion = "The sums referred to as ___.",
                        Options = ["Sequence", "Triangular number", "Amicable number", "Perfect square"],
                        Answer = "Triangular number"
                    },

                    new()
                    {
                        StrQuestion = "Which one of the following is correct for Harmonic progression?",
                        Options = ["A", "B", "C", "D"],
                        Answer = "A"
                    },

                    new()
                    {
                        StrQuestion = "Find the sum of the first twenty-five odd numbers.",
                        Options = ["526", "625", "265", "562"],
                        Answer = "625"
                    },
                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "If the second term and fourth term of an exponential function are 6 and 54, find the ___ term.",
                        Options = ["A", "B", "C", "D"],
                        Answer = "C"
                    },

                    new()
                    {
                        StrQuestion = "The first term of a geometric progression is 10 and the sum to infinity is 20. Find the common ratio.",
                        Options = ["2", "B", "C", "4"],
                        Answer = "B"
                    },

                    new()
                    {
                        StrQuestion = "The first term of an A.P. is 4 while the sum to infinity is 20. Find the common ratio.",
                        Options = ["4", "5", "B", "4"],
                        Answer = "B"
                    },

                    new()
                    {
                        StrQuestion = "If the sixth term of an arithmetic progression is 11 and the first term is 1, find the common difference.",
                        Options = ["2", "B", "C", "4"],
                        Answer = "2"
                    },

                    new()
                    {
                        StrQuestion = "The fourth term of an arithmetic progression is 13 while the tenth term is 31. Find the twenty-first term.",
                        Options = ["46", "64", "B", "3"],
                        Answer = "64"
                    },
                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "The second term and the fourth term of a geometric progression are 8 and 32 respectively. What is the sum of the first four terms?",
                        Options = ["2", "4", "60", "15"],
                        Answer = "60"
                    },

                    new()
                    {
                        StrQuestion = "Express the recurring decimal as a fraction in its lowest terms.",
                        Options = ["A", "B", "C", "D"],
                        Answer = "B"
                    },

                    new()
                    {
                        StrQuestion = "For what value of ___ does the series ___?",
                        Options = ["A", "B", "C", "D"],
                        Answer = "C"
                    },

                    new()
                    {
                        StrQuestion = "How many terms of the series must be taken for the sum to exceed 30?",
                        Options = ["4", "3", "6", "5"],
                        Answer = "6"
                    },

                    new()
                    {
                        StrQuestion = "Insert three arithmetic means between 3 and 19. What is the sum of the linear function?",
                        Options = ["4", "15", "19", "55"],
                        Answer = "55"
                    },
                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "How many terms are there in a sequence of arithmetic progression whose the sum of the first and last term are 4 and 26 respectively and the sum of the terms is 180?",
                        Options = ["12", "10", "4", "30"],
                        Answer = "12",
                    },

                    new()
                    {
                        StrQuestion = "Find a, b in the sequence 7, 1/2, a, b, 4, where the first three terms are in arithmetic sequence and the last three are in geometric sequence.",
                        Options = ["a = -6, b = 2√6", "a = 3, b = 2", "a = -5, b = 5", "a = 2, b = 3"],
                        Answer = "a = -6, b = 2√6",
                    },

                    new()
                    {
                        StrQuestion = "Find x, y in the sequence x, 25/4, 5, b, where the first three terms are in arithmetic sequence and the last three are in geometric sequence.",
                        Options = ["x = 15/2, b = 4", "x = 10, b = 6", "x = 20, b = 3", "x = 18, b = 5"],
                        Answer = "x = 15/2, b = 4",
                    },

                    new()
                    {
                        StrQuestion = "An uncle places a sum of money in a saving account for a nephew when he was born. On each succeeding birthday, the uncle deposits twice as much as on the previous birthday. The total sum of the first 11 deposits is $20,480. How large was the first deposit?",
                        Options = ["$20", "$10", "$100", "$1000"],
                        Answer = "$10",
                    },

                    new()
                    {
                        StrQuestion = "A father places a sum of money in a saving account for his daughter when she was born. On each succeeding birthday, the father deposits two more than on the previous birthday. The total sum of the first thirteen deposits is #40,955. How large were the last three deposits?",
                        Options = ["#2591", "#1259", "#9521", "#5912"],
                        Answer = "#9521",
                    },
                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Express (𝑛 + 𝑟/𝑛 − 𝑟) in factorial form.",
                        Options = ["(𝑛+𝑟)!/(2𝑟)!(𝑛−𝑟)!", "(𝑛+𝑟)!/(2𝑟)!(𝑛−𝑟+1)!", "𝑛!/2!𝑟!", "(𝑛−𝑟)!/(2𝑟)!(𝑛+𝑟)!"],
                        Answer = "(𝑛+𝑟)!/(2𝑟)!(𝑛−𝑟)!",
                    },

                    new()
                    {
                        StrQuestion = "Find the value of 𝑛 when (𝑛 − 2/1 ) = 5",
                        Options = ["5", "6", "7", "8"],
                        Answer = "7",
                    },

                    new()
                    {
                        StrQuestion = "Express 𝑛(𝑛−1)/2 in factorial form.",
                        Options = ["𝑛(𝑛−1)!/2!", "𝑛(𝑛+1)!/2!", "𝑛!/2!", "𝑛!/(𝑛−2)!2!"],
                        Answer = "𝑛!/(𝑛−2)!2!",
                    },

                    new()
                    {
                        StrQuestion = "Find the term independent of 𝑦 in the expansion of (1/2 𝑥 + 3𝑦)¹⁰⁰⁰",
                        Options = ["(𝑥²)¹⁰⁰⁰", "𝑥²¹⁰⁰", "(𝑥²)¹⁰⁰", "𝑥²¹⁰"],
                        Answer = "(𝑥²)¹⁰⁰⁰",
                    },

                    new()
                    {
                        StrQuestion = "In the expansion of (1/2 𝑥 + 3𝑦)¹⁰⁰⁰, find the coefficient of 𝑥 in the term independent of 𝑦.",
                        Options = ["1/2100", "1/21000", "𝑥²/2100", "𝑥²/2"],
                        Answer = "1/21000",
                    },
                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new() {
                        StrQuestion = "Given U_r = a + (r - 1) d in the sequence 2, 5, 8, 11, …, find the sum of the first tenth term.",
                        Options = ["513", "153", "155", "551"],
                        Answer = "155",
                    },

                    new() {
                        StrQuestion = "The sixth and thirteenth terms of an arithmetic progression are 0 and 14 respectively. Find the sum of the first twenty terms.",
                        Options = ["0", "14", "-20", "-10"],
                        Answer = "-20",
                    },

                    new() {
                        StrQuestion = "Find the geometric mean for consecutive terms x, y, z.",
                        Options = ["y = 2√xz", "y = xz", "z = xy", "y = z/x"],
                        Answer = "y = 2√xz",
                    },

                    new() {
                        StrQuestion = "Find the arithmetic mean for the consecutive terms x, y, z.",
                        Options = ["y = x + 2z", "y = (x + z) / 2", "z = x + 2y", "None"],
                        Answer = "y = (x + z) / 2",
                    },

                    new() {
                        StrQuestion = "Find the geometric mean for consecutive terms 2, 4, 8.",
                        Options = ["2", "4", "8", "16"],
                        Answer = "4",
                    },

                    new() {
                        StrQuestion = "Find the arithmetic mean for consecutive terms -3, 2, 7.",
                        Options = ["2", "7", "-3", "None"],
                        Answer = "2",
                    },

                    new() {
                        StrQuestion = "To what sum does the following series converge: 1 - 1/5 + 1/25 - ...",
                        Options = ["1/5", "5/6", "6/5", "4/5"],
                        Answer = "5/6",
                    },
                ]
            },

            new("MTS101"){
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Find the sum to which the series converges: 1/6 + 1/12 + 1/24 + ...",
                        Options = ["1/6", "2", "3", "4"],
                        Answer = "2",
                    },

                    new() {
                        StrQuestion = "Find the first term and the common difference of the three numbers in an arithmetic sequence whose sum is 12 and whose product is 64.",
                        Options = ["0, 2", "4, 0", "0, 4", "2, 0"],
                        Answer = "4, 0",
                    },

                    new() {
                        StrQuestion = "The third term and the fourth term of an arithmetic sequence are 15 and 5. What is the first term and the common difference?",
                        Options = ["35, 10", "10, -35", "35, -10", "-10, -35"],
                        Answer = "35, -10",
                    },

                    new() {
                        StrQuestion = "What is the first term and the common ratio of the geometric sequence whose third and seventh terms are -1 and -81?",
                        Options = ["-1/9, 3", "3, -1/9", "1/9, -3", "-1/9, -3"],
                        Answer = "-1/9, 3",
                    },

                    new() {
                        StrQuestion = "What is the first term and the common difference of the arithmetic sequence whose third and seventh terms are -1 and -81?",
                        Options = ["39, 20", "20, 39", "39, -20", "-20, -39"],
                        Answer = "39, -20",
                    },

                    new() {
                        StrQuestion = "Express the recurring decimal 0.3131− as a fraction in its lowest terms.",
                        Options = ["31/99", "13/99", "99/31", "31/91"],
                        Answer = "31/99",
                    },
                ]
            },

            new("MTS101")
            {
                QuestionsList =
                [

                    new()
                    {
                        StrQuestion = "Express the recurring decimal 0.2727− as a fraction in its lowest terms.",
                        Options = ["27/99", "72/99", "99/27", "None"],
                        Answer = "27/99",
                    },

                    new()
                    {
                        StrQuestion = "Find the first term of the exponential function whose common ratio of the second term and last term are 1/3 and 2/27.",
                        Options = ["2/3", "3/2", "-2/3", "-1/3"],
                        Answer = "2/3",
                    },
                    new()
                    {
                        StrQuestion = "What is the coefficient of x^r in the expansion of (1 + x)^n?",
                        Options = ["(n r - 1)", "(n + 1 r + 1)", "(n r)", "(n - 1 r)"],
                        Answer = "(n r)",
                    },

                    new()
                    {
                        StrQuestion = "One of the following has equal value as (n1).",
                        Options = ["(n n - 1)", "(n r)", "(n r)", "(n - 1 r)"],
                        Answer = "(n n - 1)",
                    },

                    new()
                    {
                        StrQuestion = "From Pascal’s triangle, addition of (n r - 1) and (n r) gives",
                        Options = ["(n + 1 r)", "(n r + 1)", "(n + 1 r - 1)", "(n r - 1)"],
                        Answer = "(n + 1 r)",
                    },
                ]
            },

            new("MTS101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "In notation form, and considering the expansion in ascending powers of x, (a + x)^n can be expressed as",
                        Options = ["∑n r=1 (n r) x^r a^(n-r)", "∑n r=0 (n r) x^r a^(n-r) +", "∑n r=0 (n r) x^(n-r) a^(n-r)", "∑n r=0 (n r) x^(n-r) a^r"],
                        Answer = "∑n r=0 (n r) x^r a^(n-r)",
                    },

                    new()
                    {
                        StrQuestion = "When we differentiate the expansion of (1 + x)^n with respect to x two times, put x = 0 and simplify, we get",
                        Options = ["(n r) = n^2", "(n 1) = 2(n+1)", "(n 2) = n(n−1)/2", "(n 2) = 2n(n−1)"],
                        Answer = "(n 2) = n(n−1)/2",
                    },

                    new()
                    {
                        StrQuestion = "For positive integer n, the factorial of n, denoted by n! is equivalent to",
                        Options = ["(n − 1)!", "n(n + 1)(n − 2)!", "(n + 1)!", "n(n − 1)(n − 2)!"],
                        Answer = "n(n − 1)(n − 2)!",
                    },

                    new()
                    {
                        StrQuestion = "The value of ∑n k=0 (n k) is",
                        Options = ["2n−2", "2n", "2n", "n^2"],
                        Answer = "2n",
                    },

                    new()
                    {
                        StrQuestion = "Expand (x + 2y)^7 in ascending powers of x",
                        Options = ["x^7 + 14x^6y + 84x^5y^2 + 280x^4y^3 + 560x^3y^4 + 672x^2y^5 + 448xy^6 + 128y^7",
                                   "128y^7 + 448xy^6 + 672x^2y^5 + 560x^3y^4 + 280x^4y^3 + 84x^5y^2 + 14x^6y + x^7",
                                   "x^7 + 4x^6y + 84x^5y^2 + 28x^4y^3 + 56x^3y^4 + 672x^2y^5 + 448xy^6 + 128y^7",
                                   "128y^7 + 448xy^6 + 62x^2y^5 + 560x^3y^4 + 280x^4y^3 + 8x^5y^2 + 14x^6y + x^7"],
                        Answer = "128y^7 + 448xy^6 + 672x^2y^5 + 560x^3y^4 + 280x^4y^3 + 84x^5y^2 + 14x^6y + x^7",
                    },
                ]
            },

            new("MTS101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Find the term independent of y in the expansion of (x^4 y^3 + y^2 2x)^10",
                        Options = ["105/32 x^11", "15/32 x^10", "105/32 x^10", "105 x^10"],
                        Answer = "105/32 x^10",
                    },

                    new()
                    {
                        StrQuestion = "Find the maximum coefficient in the expansion of (3x + 5)^10",
                        Options = ["26581250", "26578250", "26578125", "265781250"],
                        Answer = "265781250",
                    },

                    new()
                    {
                        StrQuestion = "Obtain the first four terms of the expansion of (1 + 3x)^(1/3) in ascending powers of x",
                        Options = ["1 + x − x^2 + 5/3 x^3", "1 − x − x^2 + 5/3 x^3", "1 − x + x^2 + 5/3 x^3", "1 + x − x^2 − 3/5 x^3"],
                        Answer = "1 + x − x^2 + 5/3 x^3",
                    },

                    new()
                    {
                        StrQuestion = "Obtain the expansion of √(9 + x^2) as far as the term in x^4",
                        Options = ["3 + 1/3 x^2 + x − 1/216 x^4", "3 + 1/6 x^2 − 1/216 x^4", "3 − 1/6 x^2 − 1/216 x^4", "3 + 1/6 x^2 + 1/216 x^4"],
                        Answer = "3 + 1/6 x^2 − 1/216 x^4",
                    },

                    new()
                    {
                        StrQuestion = "Find the constant term in the expansion of (2z^2 + 1z)^9",
                        Options = ["A", "B", "C", "D"],
                        Answer = "A",
                    },
                ]
            },

            new("MTS101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Find the middle term in the expansion of (x^2 + y^2)^8.",
                        Options = ["A", "B", "C", "D"],
                        Answer = "A",
                    },

                    new()
                    {
                        StrQuestion = "Find the fifth term in the expansion of (−3x − 4y)^6 in descending order of x.",
                        Options = ["A", "B", "C", "D"],
                        Answer = "A",
                    },

                    new()
                    {
                        StrQuestion = "For what value of x is the expansion of 1/(a + bx) valid?",
                        Options = ["|x| < a/b", "|x| > a/b", "|x| < 1/b", "|x| < a/2"],
                        Answer = "|x| < a/b",
                    },

                    new()
                    {
                        StrQuestion = "Find the sum of the constant coefficients in the expansion of (3 + 2x)^4",
                        Options = ["620", "630", "625", "216"],
                        Answer = "625",
                    },

                    new()
                    {
                        StrQuestion = "Find the first four terms in the expansion of (1 − 3x^2)^5 in ascending powers of x",
                        Options = ["1 − 15x^2 + 90x^4 − 270x^6", "1 + 15x^2 + 90x^4 − 270x^6", "1 − 15x^2 − 90x^4 + 270x^6", "1 + 15x^2 + 90x^4 + 270x^6"],
                        Answer = "1 − 15x^2 + 90x^4 − 270x^6",
                    },
                ]
            },

            new("MTS101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "State the value of |x| for which the expression (27 − 6x)^(-2/3) can be expanded as a series of ascending powers of x.",
                        Options = ["|x| < 2/9", "|x| < 9/2", "|x| < 1/9", "|x| > 2/9"],
                        Answer = "|x| < 9/2",
                    },

                    new()
                    {
                        StrQuestion = "State the condition under which the expansion of (x + 2y)^(-5) will be valid in ascending powers of y.",
                        Options = ["|yx| < 1/2", "|yx| < 1", "|yx| > 1/2", "|yx| < 1/2"],
                        Answer = "|yx| < 1/2",
                    },

                    new()
                    {
                        StrQuestion = "Simplify (n r+1) / (n r)",
                        Options = ["r+1/n−r", "n − r", "r + 1", "n−r r+1"],
                        Answer = "n−r r+1",
                    },

                    new()
                    {
                        StrQuestion = "Find the term independent of y in the expansion of (x^45 − 2x^3y)^10",
                        Options = ["1048576 x^50", "1048576 x^20", "1048576 y^30", "1048576 x^30"],
                        Answer = "1048576 x^30",
                    },

                    new()
                    {
                        StrQuestion = "Find the fifth term in the expansion of (3x + 2y^2)^12 in descending powers of x",
                        Options = ["5196312 x^8 y^8", "51963120 x^6 y^9", "51963120 x^7 y^8", "51963120 x^8 y^8"],
                        Answer = "51963120 x^8 y^8",
                    },
                ]
            },

            new("MTS101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Find the value of (10 r) / (10 r+1)",
                        Options = ["r+1/n−r", "r/n−r", "r−1/n+r", "n−r/n+r"],
                        Answer = "r+1/n−r",
                    },
                    new()
                    {
                        StrQuestion = "Evaluate the term independent of 𝑥 in the binomial expansion of (𝑥² − 21𝑥)⁹",
                        Options = ["16/21", "21/16", "21", "16"],
                        Answer = "21",
                    },

                    new()
                    {
                        StrQuestion = "Find the constant term in the expansion of (𝑥² − 𝑥²)⁶",
                        Options = ["360", "240", "140", "420"],
                        Answer = "240",
                    },

                    new()
                    {
                        StrQuestion = "Find the value of ∑₅ 𝑘=1 𝑘 (𝑘⁵)",
                        Options = ["60", "6", "32", "80"],
                        Answer = "80",
                    },

                    new()
                    {
                        StrQuestion = "Find the value of ∑₈ 𝑟=₃ 𝑟! (8𝑟)",
                        Options = ["10802", "10956", "109536", "10804"],
                        Answer = "109536",
                    },
                ]
            },

            new("MTS101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Express 𝑛 in factorial form.",
                        Options = ["𝑛!", "(𝑛 − 1)!", "𝑛!/(𝑛−1)!", "𝑛!(𝑛−1)"],
                        Answer = "𝑛!/(𝑛−1)!",
                    },

                    new()
                    {
                        StrQuestion = "Find the binomial expansion of (1 + 3/4 𝑥)⁴ in descending powers of 𝑥.",
                        Options = ["81/256 𝑥⁴ + 27/16 𝑥³ + 27/8 𝑥² + 3𝑥 + 1", "1 + 3𝑥 + 27/8 𝑥² + 27/16 𝑥³ + 81/256 𝑥⁴", "81/256 𝑥⁴ − 27/16 𝑥³ + 27/8 𝑥² − 3𝑥 + 1", "81/256 𝑥⁴ − 27/16 𝑥³ − 27/8 𝑥² + 3𝑥 − 1"],
                        Answer = "81/256 𝑥⁴ + 27/16 𝑥³ + 27/8 𝑥² + 3𝑥 + 1",
                    },

                    new()
                    {
                        StrQuestion = "Find the coefficient of 𝑥⁴ in the expansion of (1 + 3/4 𝑥)⁴",
                        Options = ["8/25", "81/25", "81/256", "81/26"],
                        Answer = "81/256",
                    },

                    new()
                    {
                        StrQuestion = "Find the coefficient of 𝑥 in the expansion of (1 + 3/4 𝑥)⁴",
                        Options = ["1", "2", "3", "31"],
                        Answer = "3",
                    },

                    new()
                    {
                        StrQuestion = "Find the value of 𝑛 when (𝑛²) = 120.",
                        Options = ["-15", "15", "-16", "16"],
                        Answer = "16",
                    },
                ]
            },

            new("MTS101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Determine the greatest coefficient in the expansion of (3𝑥 + 1)⁸",
                        Options = ["17496", "20412", "2941", "204120"],
                        Answer = "20412",
                    },

                    new()
                    {
                        StrQuestion = "Find the constant term in the expansion of (3𝑥 + 1)⁸",
                        Options = ["1", "2", "3", "4"],
                        Answer = "1",
                    },

                    new()
                    {
                        StrQuestion = "Find the value of 𝑥 for which the expansion of (2 + 1/4 𝑥)⁵ is valid",
                        Options = ["|𝑥| < 2", "|𝑥| < 4", "|𝑥| < 8", "|𝑥| < 1/2"],
                        Answer = "|𝑥| < 2",
                    },

                    new()
                    {
                        StrQuestion = "Evaluate ∑₅ 𝑟=1(𝑟 + 3)!",
                        Options = ["46224", "4624", "4224", "4622834"],
                        Answer = "46224",
                    },

                    new()
                    {
                        StrQuestion = "Simplify (𝑛 + 1/𝑛 − 1) + (𝑛/𝑛 − 1)",
                        Options = ["2/𝑛+3", "2/𝑛²+3", "𝑛²+3𝑛²", "𝑛²−3𝑛²"],
                        Answer = "𝑛²+3𝑛²",
                    },
                ]
            },

            new("MTS101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Find the term independent of 𝑦 in the expansion of (𝑥⁴/3𝑦³ + 𝑦²/2𝑥)⁵",
                        Options = ["5/36 𝑥⁵", "5/6 𝑥⁵", "36/5 𝑥⁵", "36𝑥⁵"],
                        Answer = "5/36 𝑥⁵",
                    },

                    new()
                    {
                        StrQuestion = "Find the coefficient of 𝑥¹⁴ in the expansion of (20𝑥² − 1)⁸",
                        Options = ["10240000000", "10240000", "−10240000000", "1024000000"],
                        Answer = "−10240000000",
                    },

                    new()
                    {
                        StrQuestion = "Take away the coefficient of 𝑥¹⁴ in the expansion of (20𝑥² − 1)⁸ from the coefficient of 𝑥¹⁴ in the expansion of (1 + 𝑥)¹⁴",
                        Options = ["10240000001", "1024000", "10240000", "1024000001"],
                        Answer = "10240000001",
                    },
                ]
            },

            new("MTS101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Find the coefficient of 𝑥⁴ in the expansion of (2𝑥 − 𝑥³²)⁴",
                        Options = ["16", "32", "42", "14"],
                        Answer = "16",
                    },

                    new()
                    {
                        StrQuestion = "Find the constant term in the expansion of (𝛽¹² − 𝛽)¹⁸",
                        Options = ["18564", "1856", "64531", "185640"],
                        Answer = "18564",
                    },

                    new()
                    {
                        StrQuestion = "Simplify (𝑛 + 1/𝑛 − 1) − (𝑛/𝑛 − 1)",
                        Options = ["𝑛²−3𝑛²", "𝑛²+3𝑛²", "𝑛(𝑛+1)/2", "𝑛(𝑛−1)/2"],
                        Answer = "𝑛(𝑛−1)/2",
                    },

                    new()
                    {
                        StrQuestion = "Simplify (𝑛+1/𝑛−1)(𝑛𝑛−1)",
                        Options = ["𝑛−1/2", "𝑛+1/2", "𝑛²", "𝑛²+1"],
                        Answer = "𝑛²+1",
                    },
                ]
            },

            #endregion

            //MTS 201 201 201 201 201 201 201
            //MTS 201 201 201 201 201 201 201
            //MTS 201 201 201 201 201 201 201
            //MTS 201 201 201 201 201 201 201
#region "MTS201"
            new("MTS201")
           {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Consider the function Z(x,y): Z = x<sup>2</sup> + xy + y<sup>2</sup> + 5x - 5y + 3 and determine the stationery points ",
                        Options = [ "(-5,5)", "(5,-5)","(0,5)","(5,3)"],
                        Answer = "(-5,5)",
                    },

                    new()
                    {
                        StrQuestion = "It has cost ₦200 and a new item cost ₦15. Find the cost of Producing.",
                        Options = ["₦200", "₦215", "₦250", "₦230"],
                        Answer = "₦230",
                    },
                ],
           },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Consider the function Z(x,y): Z = x<sup>2</sup> + xy + y<sup>2</sup> + 5x - 5y + 3 and determine the stationery points ",
                        Options = ["(1, 0)", "(-1, 0)", "(0, ±√3)", "(2, 2)"],
                        Answer = "(0, ±√3)",
                    },

                    new()
                    {
                        StrQuestion = "Each term Product after 5 hours is 2000, and the number is increasing by 100 per hour. Approximate the total number of Bacteria after five and a half hours (330 minutes).",
                        Options = ["2000", "2050", "2100", "2200"],
                        Answer = "2050",
                    },

                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "From question ② above, which is a Saddle Point?",
                        Options = ["(1, 0)", "(0, ±√3)",  "(-1, 0)", "(2, 2)"],
                        Answer = "(0, ±√3)",
                    },

                    new()
                    {
                        StrQuestion = "Estimate 26% with a rational number using Linear Approximation.",
                        Options = ["0", "1", "L(x) = 2.46216 or f(x) ≈ 2.46216", "∞"],
                        Answer = "L(x) = 2.46216 or f(x) ≈ 2.46216",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "From question ③ above, determine the minimum Point.",
                        Options = ["(1, 0)", "(-1, 0)", "(0, ±√3)", "(2, 2)"],
                        Answer = "(1, 0)",
                    },
                    new()
                    {
                        StrQuestion = "A rectangular box of length 45 cm, width 60 cm, and height/depth 40 cm. Assuming the error in each dimension is the same (i.e., δk = 6b = 6h) as 0.2 cm, what is the change in Volume of the box?",
                        Options = [ "δV = 0", "δV = 1000 cm³", "δV = 2000 cm³", "δV = 1980 cm³"],
                        Answer = "δV = 1980 cm³",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Consider the function Z(x, y): Z = x⁴ + 4x²y² − 2xz² + 2y² − 1 and determine the Saddle Point.",
                        Options = ["(1, 0)", "(-1, 0)", "(0, 0)",  "(2, 2)"],
                        Answer = "(0, 0)",
                    },

                                        new()
                    {
                        StrQuestion = "The force vector on an object is F = x²i + y²j, and it is displaced in position Y = xi + yj. Calculate the Work done on the Object from A(0,0) to B(1,1) if y = x².",
                        Options = ["0 Joules", "12 Joules", "24 Joules", "48 Joules"],
                        Answer = "24 Joules",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "From question ⑤ above, check and determine the Maximum-Lifting Point.",
                        Options = [ "(1, 0)", "None, there's no Maximum Point", "(-1, 0)", "(0, 0)"],
                        Answer = "None, there's no Maximum Point",
                    },

                    new()
                    {
                        StrQuestion = "The Maple of a Company P is proportional to x (number of F items produced) and x' is proportional to t (time taken in production). If the Company starts with a Maple of ₦800000 and the rate of Maple made per item produced is ₦200, also the rate of producing an item for a time interval is 150 per year, estimate the total Maple made in 4 years from now.",
                        Options = ["P = ₦800000", "P = ₦420000", "P = ₦200000", "P = ₦100000"],
                        Answer = "P = ₦420000",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What are the Lifting Points for Question ⑤ above?",
                        Options = ["(0, 0)", "(2, 2)", "(1, 0) and (-1, 0)", "(3, 3)"],
                        Answer = "(1, 0) and (-1, 0)",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "From the Taylor Series Explanation Q: T_An = (x/y)^n, find f_x at (1,1).",
                        Options = ["-√2 or -0.5", "1 or 0.5", "2 or 1.5", "0 or 0"],
                        Answer = "-√2 or -0.5",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "From the Taylor Series expansion Q: T_An = (y/z)^n, find f_xx at (1,1).",
                        Options = [ "1 or 1.5", "0 or 0","1/2 or 2/4 or 0.5", "-1 or -0.5"],
                        Answer = "1/2 or 2/4 or 0.5",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "From the Taylor Series expansion Q: T_An = (y/z)^n, find f_y at (1,1).",
                        Options = ["2 or 0.5", "1 or 1.5", "0 or 0", "-1 or -0.5"],
                        Answer = "2 or 0.5",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Find f_yy at (1,1).",
                        Options = ["2 or 0.5", "-1/2 or 24 or -0.5", "1 or 1.5", "0 or 0"],
                        Answer = "-1/2 or 24 or -0.5",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "If Z(x, y): Z = e^(x+y²), find ∂z/∂t for x = t cos t and y = t sin t at t = π/2.",
                        Options = [ "π/2", "0", "-π/2","1"],
                        Answer = "-π/2",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "For Z(x, y): Z = x³y + e^(x+y²) (z → exponential), find ∑(t=−∞ to ∞) Z_xx ∑(y=−∞ to ∞) Z_yy.",
                        Options = ["0", "1", "Not provided", "∞"],
                        Answer = "Not provided",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Consider the function f(x, y, z): x² + y² + z² = 25, find ∂z/∂x or ∑(t=−∞ to ∞) ∂z/∂t.",
                        Options = ["Not provided", "0", "1", "∞"],
                        Answer = "Not provided",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Using the same question as ⑥ above, find ∑(t=−∞ to ∞) ∂z/∂y.",
                        Options = ["0", "1", "∑(t=−∞ to ∞) ∂z/∂t", "∞"],
                        Answer = "∑(t=−∞ to ∞) ∂z/∂t",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "For Σ = x² - tan⁻¹(y/x), find ∂²z/∂x∂y.",
                        Options = ["0", "1", "Not provided", "∞"],
                        Answer = "Not provided",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "For γ = xe⁻ˣ and 5 ≤ x ≤ 5.3 (i.e., x changes from 5 to 5.3), find the change in γ based on y by -0.00809.",
                        Options = [ "0", "1", "∞"],
                        Answer = "Not provided",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "For γ = xe⁻ˣ and x changes from 5 to 5.03, find the change in γ based on x. If y is -0.000804.",
                        Options = ["Not provided", "0", "1", "∞"],
                        Answer = "Not provided",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "The sides of a square are each measured as x. Find the change in the Area for a Small Change in dimensions of the Square (i.e., δx).",
                        Options = ["δA = xδx", "δA = 3xδx", "δA = 2xδx", "δA = 0"],
                        Answer = "δA = 2xδx",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "A Core of radius r = loc_xy, height h = 25 cm, and change in r = change in h (i.e., δr = δh) which is 0.1 cm, find the Change in Volume (V) of the Core in terms of x.",
                        Options = ["δV = 1.0π", "δV = 3.0π", "δV = 2.0π", "δV = 0"],
                        Answer = "δV = 2.0π",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "A right-angled triangle of adjacent sides a, b has a hypotenuse h. If there's a ±0.5 error in the measurement of a and b each, find the Percentage Error in the hypotenuse.",
                        Options = ["δh = ±0.5", "δh = ±0.5√h or ±0.5√(a² + b²)", "δh = ±1.0", "δh = 0"],
                        Answer = "δh = ±0.5√h or ±0.5√(a² + b²)",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Using the same question, find the Percentage error in the Area of the triangle A in terms of a.",
                        Options = ["δA = ±1√h or ±1√(0.5ab)", "δA = ±0.5", "δA = ±1.0", "δA = 0"],
                        Answer = "δA = ±1√h or ±1√(0.5ab)",
                    },
                ],
            },


            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "For Σ = x² + 3xy - y², find the change in Σ for -2.1 < x < 2.05 and 3 < y < 2.06.",
                        Options = ["δΣ ≥ 0.65", "δΣ = 0", "δΣ = 1", "δΣ = ∞"],
                        Answer = "δΣ ≥ 0.65",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "For γ = k ⋃(i=1 to n) a_i, following the expression and given W increases by 3h, it increases by 2.5h, and it increases by 4h, find the change in γ if k is constant in the expression.",
                        Options = [ "Increases by 2h", "Increases by 3h","Increases by 1h", "Increases by 4h"],
                        Answer = "Increases by 1h",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "For γ = xe⁻ˣ and there is a 2h change in x, find the change in γ in terms of x.",
                        Options = ["δγ = 2f(x)⋅γ", "δγ = 0", "δγ = 1", "δγ = ∞"],
                        Answer = "δγ = 2f(x)⋅γ",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "For question 26 above, find for what value of x will there not be a change in γ (i.e., when δγ = 0).",
                        Options = ["x = 1", "x = 0", "x = 2", "x = ∞"],
                        Answer = "x = 1",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "For question 26 above, determine for what values of x will γ start decreasing (i.e., again Change).",
                        Options = ["x < 1", "x > 1", "x = 1", "x = ∞"],
                        Answer = "x > 1",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "For γ = x² sin x, and x = 3 when x changes by 0.067, find the Change in γ.",
                        Options = ["δγ = 0", "δγ = 1", "δγ = 0.558 to 3 decimal places",  "δγ = ∞"],
                        Answer = "δγ = 0.558 to 3 decimal places",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Approximate the change in γ for γ = e/x when 1 < x < 0.025.",
                        Options = ["δγ = 1", "δγ = ∞", "δγ = 0.085", "δγ = 0"],
                        Answer = "δγ = 0.085",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What is the change in γ if Y = x/(1+x) and the change in x (i.e., δx) is -5h?",
                        Options = ["δγ = 0", "δγ = 1", "δγ = 1 + x", "δγ = ∞"],
                        Answer = "δγ = 1 + x",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "The function y = (2x + 1)^5 and x changes by 0.1, therefore calculate the change in y.",
                        Options = ["δy = 0", "δy = 1", "δy = x/(2x + 1) or δy", "δy = ∞"],
                        Answer = "δy = x/(2x + 1) or δy",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Approximate the change in y for y = x³/n when x = 4 and x changes by 12% (i.e., by 6.12).",
                        Options = ["δy = 9.405", "δy = 0", "δy = 1", "δy = ∞"],
                        Answer = "δy = 9.405",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Consider y = cos(3x² + 2) and x changes by 2% (i.e., 8x - 2% x), estimate the change in y.",
                        Options = [ "δy = 0", "δy = 1","δy = -12x² + a₀(3x² + 2)", "δy = ∞"],
                        Answer = "δy = -12x² + a₀(3x² + 2)",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "For the expression D = Eh³/(12(1 - v²)), if h = 0.1 ± 0.002 and V = 0.3 ± 0.02, express the approximate maximum error in D in terms of E.",
                        Options = [ "0", "G.πE × 10⁻⁶", "1", "∞"],
                        Answer = "G.πE × 10⁻⁶",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "For ∂f/∂k = P(-n/k), using this expression and assuming error in T = 4δ and error in P = bδ, find the error in k (i.e., δk) in terms of A and b.",
                        Options = ["δk = (Δn + b)∫₀ᵇ(k)", "δk = 0", "δk = 1", "δk = ∞"],
                        Answer = "δk = (Δn + b)∫₀ᵇ(k)",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "For the expression R₁ = R₂R₃/R₄ and error in R₂ = ±X_b, R₃ = ±Y_b, and R₄ = ±Z_b, find the error in R₁ in terms of X_b, Y_b, and Z.",
                        Options = ["Not provided", "0", "Not provided", "1", "∞"],
                        Answer = "Not provided",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "If (-q²)/(x² + y² - q²) and error/change in x is equal to change in y which is P, find the change in z in terms of P.",
                        Options = [ "δz = 0", "δz = -2P(1 + z)", "δz = 1", "δz = ∞"],
                        Answer = "δz = -2P(1 + z)",
                    },
                ],
            },

            new("MTS201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "The Maple of a Company P is proportional to x (number of F items produced) and x' is proportional to t (time taken in production). If the Company starts with a Maple of ₦800000 and the rate of Maple made per item produced is ₦200, also the rate of producing an item for a time interval is 150 per year, estimate the total Maple made in 4 years from now.",
                        Options = ["P = ₦420000", "P = ₦800000", "P = ₦200000", "P = ₦100000"],
                        Answer = "P = ₦420000",
                    },
                ],
            },
#endregion
            //MTS 202 202 202 202 202 202 202
            //MTS 202 202 202 202 202 202 202
            //MTS 202 202 202 202 202 202 202
            //MTS 202 202 202 202 202 202 202
            //MTS 202 202 202 202 202 202 202
            //MTS 202 202 202 202 202 202 202
        ];

        public static List<QuestionPreset> GetQuestion(string CourseCode) => Questions_!.Where(x => (x.CourseCode == CourseCode && x.QuestionsList != null)).ToList();
    }
}
