extends Node
var mob = preload("res://Mobs.tscn")
var arrow = load("res://Crosshair/cross_normal.png")

var currentWave = 0;
var left = 0;

var waves  = [5, 10, 15];

# Called when the node enters the scene tree for the first time.
func _ready():
	
	randomize()
	pass # Replace with function body.
	
	# Replaces the cursor with a crosshair.
	Input.set_custom_mouse_cursor(arrow)



# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(_delta):
	if left == 0:
		left = waves [currentWave]
		currentWave += 1
		spawnEnemies();
	pass
	
func spawnEnemies():
	for i in range(left):
		var m = mob.instance()
		add_child(m)
		m.position = Vector2(rand_range(-1000, -100), rand_range(100, 800))
	
