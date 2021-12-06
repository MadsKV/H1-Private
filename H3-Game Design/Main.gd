extends RigidBody2D
export var min_speed = 150  # Minimum speed range.
export var max_speed = 250  # Maximum speed range.

var mob = preload("res://Mobs.tscn")

# Called when the node enters the scene tree for the first time.
func _ready():
	var m = mob.instance()
	add_child(m)
	m.position = Vector2(100, 100)
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(_delta):

	pass
