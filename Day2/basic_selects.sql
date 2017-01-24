-- This is a comment

SELECT Band.name, title, release_date
FROM Album
INNER JOIN Band ON Band.id = Album.band
WHERE title LIKE '%up%';

SELECT Band.name, title, release_date
FROM Album
INNER JOIN Band ON Band.id = Album.band
WHERE Band.name = 'NOFX';