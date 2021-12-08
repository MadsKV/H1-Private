extends RigidBody2D
export var min_speed = 50  # Minimum speed range.
export var max_speed = 150  # Maximum speed range.

var speed = 0;



# Called when the node enters the scene tree for the first time.
func _ready():
	speed = rand_range(min_speed, max_speed);
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	position.x += speed * delta

	pass
