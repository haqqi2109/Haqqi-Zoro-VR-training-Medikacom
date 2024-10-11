var nilai = 90;

if (nilai > 90){
    grade = "A";
} else if (nilai >= 80 && nilai <=91){
    grade = "B";
} else if (nilai >= 75 && nilai <81){
    grade = "c";
} else{
    grade = "D";
}


document.write("nilai: " + nilai + " termasuk: " + grade);