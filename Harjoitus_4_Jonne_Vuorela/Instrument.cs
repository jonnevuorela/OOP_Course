abstract class Instrument
{
   abstract public void Play();
   abstract public void Tune();
}

//Keyboards
abstract class KeyboardInstrument : Instrument
{
   abstract public void PressKey();
}

class Piano : KeyboardInstrument
{
   public override void Play()
   {
      throw new NotImplementedException();
   }
   public override void PressKey()
   {
      throw new NotImplementedException();
   }
   public override void Tune()
   {
      throw new NotImplementedException();
   }
}
//StringInstruments
abstract class StringInstrument : Instrument
{
   abstract public void Strum();
   abstract public void HoldStrings();
}

class ElectricGuitar : StringInstrument
{
   public override void HoldStrings()
   {
      throw new NotImplementedException();
   }

   public override void Play()
   {
      throw new NotImplementedException();
   }

   public override void Strum()
   {
      throw new NotImplementedException();
   }

   public override void Tune()
   {
      throw new NotImplementedException();
   }
}

class BassGuitar : StringInstrument
{
   public override void HoldStrings()
   {
      throw new NotImplementedException();
   }

   public override void Play()
   {
      throw new NotImplementedException();
   }

   public override void Strum()
   {
      throw new NotImplementedException();
   }

   public override void Tune()
   {
      throw new NotImplementedException();
   }
}

class AcousticGuitar : StringInstrument
{
   public override void HoldStrings()
   {
      throw new NotImplementedException();
   }

   public override void Play()
   {
      throw new NotImplementedException();
   }

   public override void Strum()
   {
      throw new NotImplementedException();
   }

   public override void Tune()
   {
      throw new NotImplementedException();
   }
}

