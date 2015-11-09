/// <binding ProjectOpened='compile-typescript' />
var
    gulp = require('gulp'),
    source = require('vinyl-source-stream'),
    buffer = require('vinyl-buffer'),
    globby = require('globby'),
    through = require('through2'),
    gutil = require('gulp-util'),
    ts = require('gulp-typescript'),
    sourcemaps = require('gulp-sourcemaps'),
    watch = require('gulp-watch'),
    tslint = require('gulp-tslint'),
    concat = require('gulp-concat'),
    browserify = require('browserify'),
    tsify = require('tsify'),
    config = {
        tsappfiles: "./Scripts.App/src/**/*.ts",
        tsprojoverride: {
            files: [
                "./tools/typings/**/*.ts",
                this.tsappfiles
            ]
        },
        ts: {
            src: [
                'tools/typings/**/*.ts',
                'Scripts.App/src/**/*.ts'
            ],
            mapfile: 'app.map',
            destDir: './Scripts/App',
            entry: './Scripts.App/src/app.ts'
        },
        js: {
            dest: 'Scripts.App/',
            destfile: 'app.js'
        }
    },
    tsProject = ts.createProject('tsconfig.json', config.tsprojoverride);

gulp.task('lint-ts', function () {
    return gulp.src(config.tsappfiles)
        .pipe(tslint())
        .pipe(tslint.report('prose'));
});

gulp.task('compile-ts', function () {
    var b = browserify({
        entries: [
            'tools/typings/**/*.ts',
            js.ts.entries
            ],
        debug: true
    }).plugin('tsify');

    return b
        .bundle()
        .pipe(source(config.js.destfile))
        .pipe(buffer())
        .pipe(sourcemaps.init({ loadMaps: true }))
            .on('error', gutil.log)
        .pipe(sourcemaps.write('./'))
        .pipe(gulp.dest(config.js.dest));
});

gulp.task('watch', function () {
    return gulp.src(config.ts.source)
        .pipe(watch())

});

gulp.task('dev', ['compile-typescript', 'watch'], function () {

});