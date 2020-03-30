import massive.munit.TestSuite;

import engine.ConditionResultTest;
import engine.ConditionTest;
import engine.EngineTest;
import engine.RuleResultTest;
import engine.RuleTest;

/**
 * Auto generated Test Suite for MassiveUnit.
 * Refer to munit command line tool for more information (haxelib run munit)
 */
class TestSuite extends massive.munit.TestSuite
{
	public function new()
	{
		super();

		add(engine.ConditionResultTest);
		add(engine.ConditionTest);
		add(engine.EngineTest);
		add(engine.RuleResultTest);
		add(engine.RuleTest);
	}
}
