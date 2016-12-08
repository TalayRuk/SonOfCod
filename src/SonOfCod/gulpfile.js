/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp'),
    concat = require("gulp-concat"),
    uglify = require("gulp-uglify");


gulp.task("min:js", function () {
    return gulp.src(["./wwwroot/app/**/*.js", "!" + "./wwwroot/app/**/*.min.js"], { base: "." })
        .pipe(concat("./wwwroot/js/site.min.js"))
        .pipe(uglify())
        .pipe(gulp.dest("."));
});